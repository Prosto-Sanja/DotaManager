using System;
using System.Collections.Generic;
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

        public DotaManager(SteamClient steamClient, CallbackManager callbackManager)
        {
            _steamClient = steamClient;
            _callbackManager = callbackManager;
        }

        public void Start()
        {
            _callbackManager.Subscribe<SteamGameCoordinator.MessageCallback>(OnGcMessage);
            var playGame = new ClientMsgProtobuf<CMsgClientGamesPlayed>(EMsg.ClientGamesPlayed);

            playGame.Body.games_played.Add(new CMsgClientGamesPlayed.GamePlayed
            {
                game_id = new GameID(570), // or game_id = APPID,
            });

            _steamClient.Send(playGame);
        }

        // called when a gamecoordinator (GC) message arrives
        // these kinds of messages are designed to be game-specific
        // in this case, we'll be handling dota's GC messages
        static void OnGcMessage(SteamGameCoordinator.MessageCallback callback)
        {

            // setup our dispatch table for messages
            // this makes the code cleaner and easier to maintain
            var messageMap = new Dictionary<uint, Action<IPacketGCMsg>>
            {
               // { ( uint ) ESOMsg.k_ESOMsg_CacheSubscribed, CacheSubscribed }
            };

            Action<IPacketGCMsg> func;
            if (!messageMap.TryGetValue(callback.EMsg, out func))
            {
                // this will happen when we recieve some GC messages that we're not handling
                // this is okay because we're handling every essential message, and the rest can be ignored
                Console.WriteLine("Received unhandled message: " + callback.EMsg);
                return;
            }
            else if (func == null)
            {
                return;
            }

            func(callback.Message);
        }

    }
}
