using System;
using System.IO;
using System.Windows.Forms;
using ProtoBuf;
using SteamKit2;
using SteamKit2.GC;
using SteamKit2.GC.Dota.Internal;

namespace DotaManager.Dota_Operations.Caches
{
    internal class PartyInvite
    {
        private SteamGameCoordinator _steamGameCoordinator;

        public PartyInvite(SteamGameCoordinator steamGameCoordinator)
        {
            _steamGameCoordinator = steamGameCoordinator;
        }

        public void HandleInvite(byte[] cache)
        {
            using (var stream = new MemoryStream(cache))
            {
                var party = Serializer.Deserialize<CSODOTAPartyInvite>(stream);
                var message = "You were invited to a ";
                if (party.low_priority_status == false)
                {
                    message += "high priority party\n";
                }
                else
                {
                    message += "LOW priority party\n";
                }
                message += "Invite from: " + party.sender_name + "\n";
                message += "People in party: \n";
                foreach (var member in party.members)
                {
                    message += "---" + member.name;
                    if (member.is_coach)
                    {
                        message += " as coach";
                    }
                    message += "\n";
                }
                message += "Accept?";
                var partyinviteresponse = new ClientGCMsgProtobuf<CMsgPartyInviteResponse>((uint)EGCBaseMsg.k_EMsgGCPartyInviteResponse);
                partyinviteresponse.Body.party_id = party.group_id;
                if (MessageBox.Show(message, "Party invite received", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    partyinviteresponse.Body.accept = true;
                }
                else
                {
                    partyinviteresponse.Body.accept = false;
                }
                _steamGameCoordinator.Send(partyinviteresponse, 570);
            }
        }
    }
}
