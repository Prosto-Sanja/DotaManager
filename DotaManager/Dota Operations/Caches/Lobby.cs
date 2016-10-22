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
    class Lobby
    {
        private SteamGameCoordinator _steamGameCoordinator;
        private TextBox _lobbyMessageBox;

        public Lobby(SteamGameCoordinator steamGameCoordinator, TextBox messageBox)
        {
            _steamGameCoordinator = steamGameCoordinator;
            _lobbyMessageBox = messageBox;
        }

        public void HandleLobby(byte[] cache)
        {
            using (var stream = new MemoryStream(cache))
            {
                var lobby = Serializer.Deserialize<CSODOTALobby>(stream);
                SetLobbyBoxText(JsonConvert.SerializeObject(lobby, Formatting.Indented));
            }
        }

        private void SetLobbyBoxText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (_lobbyMessageBox.InvokeRequired)
            {
                SetStatusTextCallback d = SetLobbyBoxText;
                _lobbyMessageBox.Invoke(d, text);
            }
            else
            {
                _lobbyMessageBox.Text = text;
            }
        }

        private delegate void SetStatusTextCallback(string text);

    }
}
