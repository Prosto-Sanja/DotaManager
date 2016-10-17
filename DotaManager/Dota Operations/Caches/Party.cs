using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProtoBuf;
using SteamKit2;
using SteamKit2.GC.Dota.Internal;

namespace DotaManager.Dota_Operations.Caches
{
    class Party
    {
        private SteamGameCoordinator _steamGameCoordinator;
        private TextBox _partyMessageBox;

        public Party(SteamGameCoordinator steamGameCoordinator, TextBox messageBox)
        {
            _steamGameCoordinator = steamGameCoordinator;
            _partyMessageBox = messageBox;
        }

        public void HandleParty (byte[] cache)
        {
            using (var stream = new MemoryStream(cache))
            {
                var party = Serializer.Deserialize<CSODOTAParty>(stream);
                SetPartyBoxText(JsonConvert.SerializeObject(party, Formatting.Indented));
            }
        }

        private void SetPartyBoxText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (_partyMessageBox.InvokeRequired)
            {
                SetStatusTextCallback d = SetPartyBoxText;
                _partyMessageBox.Invoke(d, text);
            }
            else
            {
                _partyMessageBox.Text = text;
            }
        }

        private delegate void SetStatusTextCallback(string text);


    }
}
