using System;
using System.Collections.Generic;
using System.Threading;
using DotaManager.Data_Classes.Enums;
using SteamKit2;
using SteamKit2.GC;
using SteamKit2.GC.Dota.Internal;
using SteamKit2.Internal;

namespace DotaManager
{
    internal class DotaManager
    {

        private SteamClient _steamClient;
        private CallbackManager _callbackManager;
        private SteamGameCoordinator _steamGameCoordinator;

        private DotaManagerStatus _status = DotaManagerStatus.Stopped;

        // setup our dispatch table for messages
        // this makes the code cleaner and easier to maintain
        private Dictionary<uint, Action<IPacketGCMsg>> _messageMap = new Dictionary<uint, Action<IPacketGCMsg>>();
        private Dictionary<CacheSubscritionTypes, Action<byte[]>> _cacheMap = new Dictionary<CacheSubscritionTypes, Action<byte[]>>();

        public DotaManager(SteamClient steamClient, CallbackManager callbackManager)
        {
            _steamClient = steamClient;
            _callbackManager = callbackManager;
        }

        public void Start()
        {
            //get game coordinator handler, use in game
            _steamGameCoordinator = _steamClient.GetHandler<SteamGameCoordinator>();
            _callbackManager.Subscribe<SteamGameCoordinator.MessageCallback>(OnGcMessage);
            //tell that we are playing DOTA
            var playGame = new ClientMsgProtobuf<CMsgClientGamesPlayed>(EMsg.ClientGamesPlayed);
            playGame.Body.games_played.Add(new CMsgClientGamesPlayed.GamePlayed
            {
                game_id = new GameID(570), // or game_id = APPID,
            });
            _steamClient.Send(playGame);
            // delay a little to give steam some time to establish a GC connection to us
            Thread.Sleep(5000);
            // inform the dota GC that we want a session
            var clientHello = new ClientGCMsgProtobuf<CMsgClientHello>((uint) EGCBaseClientMsg.k_EMsgGCClientHello)
            {
                Body =
                {
                    engine = ESourceEngine.k_ESE_Source2,
                    client_session_need = 104
                }
            };
            AddMessageHandler((uint)EGCBaseClientMsg.k_EMsgGCClientWelcome, Connected);
            AddMessageHandler((uint)ESOMsg.k_ESOMsg_CacheSubscribed, OnCacheSubscribed);
            AddMessageHandler((uint)ESOMsg.k_ESOMsg_UpdateMultiple, OnUpdateMultiple);
            _steamGameCoordinator.Send(clientHello, 570);
            _status = DotaManagerStatus.Connecting;
        }

        // called when a gamecoordinator (GC) message arrives
        // these kinds of messages are designed to be game-specific
        // in this case, we'll be handling dota's GC messages
        private void OnGcMessage(SteamGameCoordinator.MessageCallback callback)
        {
            Action<IPacketGCMsg> func;
            if (!_messageMap.TryGetValue(callback.EMsg, out func))
            {
                // this will happen when we recieve some GC messages that we're not handling
                // this is okay because we're handling every essential message, and the rest can be ignored
                Console.WriteLine("Received unhandled message: " + callback.EMsg);
                return;
            }

            func(callback.Message);
        }

        private void Connected(IPacketGCMsg packetGcMsg)
        {
            _status = DotaManagerStatus.InGame;
        }

        private void OnCacheSubscribed(IPacketGCMsg packetGcMsg)
        {
            Action<byte[]> func;
            var sub = new ClientGCMsgProtobuf<CMsgSOCacheSubscribed>(packetGcMsg);
            foreach (var cache in sub.Body.objects)
            {
                if (!_cacheMap.TryGetValue((CacheSubscritionTypes) cache.type_id, out func))
                {
                    // this will happen when we recieve some cache messages that we're not handling
                    // this is okay because we're handling every essential message, and the rest can be ignored
                    Console.WriteLine("Subscribed unhandled cache: " + (CacheSubscritionTypes)cache.type_id);
                    return;
                }

                func(cache.object_data[0]);
            }
        }

        private void OnUpdateMultiple(IPacketGCMsg packetGcMsg)
        {
            Action<byte[]> func;
            var sub = new ClientGCMsgProtobuf<CMsgSOMultipleObjects>(packetGcMsg);
            foreach (var cache in sub.Body.objects_modified)
            {
                if (!_cacheMap.TryGetValue((CacheSubscritionTypes)cache.type_id, out func))
                {
                    // this will happen when we recieve some cache messages that we're not handling
                    // this is okay because we're handling every essential message, and the rest can be ignored
                    Console.WriteLine("Updated unhandled cache: " + (CacheSubscritionTypes)cache.type_id);
                    return;
                }

                func(cache.object_data);
            }
        }

        public void AddMessageHandler(uint key, Action<IPacketGCMsg> value)
        {
            _messageMap.Add(key, value);
        }

        public void AddCacheHandler(CacheSubscritionTypes subscritionType, Action<byte[]> value)
        {
            _cacheMap.Add(subscritionType, value);
        }

        public DotaManagerStatus Monitor()
        {
            return _status;
        }

        public SteamGameCoordinator SteamGameCoordinator => _steamGameCoordinator;

        public void Stop()
        {
            _steamClient.RemoveHandler(_steamGameCoordinator);
            _status = DotaManagerStatus.Stopped;
        }

    }
}
