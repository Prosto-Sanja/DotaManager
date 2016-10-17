using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotaManager.Dota_Operations.Caches;
using SteamKit2;
using SteamKit2.GC.Dota.Internal;

namespace DotaManager.Dota_Operations
{
    class CachesManager
    {

        private readonly DotaManager _dotaManager;
        private SteamGameCoordinator _steamGameCoordinator;
        private PartyInvite _partyInviteHandler;

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
    }
}
