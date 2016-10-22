using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotaManager.Dota_Operations.Caches;
using SteamKit2;
using SteamKit2.GC;
using SteamKit2.GC.Dota.Internal;

namespace DotaManager.Dota_Operations
{
    class CachesManager
    {

        private readonly DotaManager _dotaManager;
        private SteamGameCoordinator _steamGameCoordinator;
        private PartyInvite _partyInviteHandler;
        private Party _partyHandler;
        private Lobby _lobbyHandler;

        public CachesManager(DotaManager dotaManager)
        {
            _dotaManager = dotaManager;
            _steamGameCoordinator = dotaManager.SteamGameCoordinator;
        }

        public void RegisterPartyInviteHandler()
        {
            _partyInviteHandler = new PartyInvite(_steamGameCoordinator);
            _dotaManager.AddCacheHandler(CacheSubscritionTypes.Partyinvite, _partyInviteHandler.HandleInvite);
        }

        public void RegisterPartyHandler(TextBox partyInfoBox)
        {
            _partyHandler = new Party(_steamGameCoordinator, partyInfoBox);
            _dotaManager.AddCacheHandler(CacheSubscritionTypes.Party, _partyHandler.HandleParty);
        }

        public void RegisterLobbyHandler(TextBox lobbyInfoBox)
        {
            _lobbyHandler = new Lobby(_steamGameCoordinator, lobbyInfoBox);
            _dotaManager.AddCacheHandler(CacheSubscritionTypes.Lobby, _lobbyHandler.HandleLobby);
        }

        public void Test()
        {
            var lobby = new ClientGCMsgProtobuf<CMsgPracticeLobbyCreate>((uint) EDOTAGCMsg.k_EMsgGCPracticeLobbyCreate)
            {
                Body =
                {
                    lobby_details = new CMsgPracticeLobbySetDetails
                    {
                        allow_cheats = true,
                        visibility = DOTALobbyVisibility.DOTALobbyVisibility_Unlisted,
                        dota_tv_delay = LobbyDotaTVDelay.LobbyDotaTV_300,
                        pause_setting = LobbyDotaPauseSetting.LobbyDotaPauseSetting_Limited
                    }
                }
            };
            _steamGameCoordinator.Send(lobby, 570);
            var test = new ClientGCMsgProtobuf<CMsgPracticeLobbyJoinBroadcastChannel>((uint) EDOTAGCMsg.k_EMsgGCPracticeLobbyJoinBroadcastChannel)
                {
                    Body =
                    {
                        channel = 0,
                        preferred_country_code = "ee",
                        preferred_description = "Estonia Main",
                        preferred_language_code = "english"
                    }
                };
            _steamGameCoordinator.Send(test, 570);
            var ss = new ClientGCMsgProtobuf<CMsgInviteToLobby>((uint)EGCBaseMsg.k_EMsgGCInviteToLobby)
            {
                Body = { steam_id = new SteamID(76561198065864003) }
            };
            _steamGameCoordinator.Send(ss, 570);
        }
    }
}
