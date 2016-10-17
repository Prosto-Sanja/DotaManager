using System;
using System.Threading;
using System.Windows.Forms;
using DotaManager.Data_Classes.Enums;
using SteamKit2.GC.Dota.Internal;

namespace DotaManager
{
    public partial class FormMain : Form
    {
        private Thread _managerThread, _exceptionThread;
        private SteamManager _steamManager;
        private DotaManager _dotaManager;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_Closing(object sender, FormClosingEventArgs eventArgs)
        {
            ShutdownEvrything();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                _steamManager = new SteamManager(usernameBox.Text, passwordBox.Text);
                _managerThread = new Thread(_steamManager.Start);
                _managerThread.Start();
                _exceptionThread = new Thread(Monitor);
                _exceptionThread.Start();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.GetType().ToString());
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            ShutdownEvrything();
        }



        private void playButton_Click(object sender, EventArgs e)
        {
            _dotaManager = new DotaManager(_steamManager.SteamClient, _steamManager.CallbackManager);
            _dotaManager.Start();
        }

        //monitoring steam and dota status(dota<steam)
        private void Monitor()
        {
            try
            {
                SteamManagerStatus steamStatus;
                while ((steamStatus = _steamManager.Monitor()) != SteamManagerStatus.Stopped)
                {
                    if (_dotaManager != null)
                    {
                        SetDotaStatusText(_dotaManager.Monitor().ToString());
                    }
                    SetSteamStatusText(steamStatus.ToString());
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
                SetDotaStatusText(DotaManagerStatus.Stopped.ToString());
                SetSteamStatusText(SteamManagerStatus.Stopped.ToString());
            }
            catch (Exception exception)
            {
                SetSteamStatusText(SteamManagerStatus.Exception.ToString());
                MessageBox.Show(exception.GetType().ToString() + "\n" + exception.Message);
            }
        }

        #region thread safe GUI calls
        private void SetSteamStatusText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (SteamStatusLabel.InvokeRequired)
            {
                SetStatusTextCallback d = SetSteamStatusText;
                Invoke(d, text);
            }
            else
            {
                SteamStatusLabel.Text = "Status: " + text;
            }
        }
        private void SetDotaStatusText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (dotaStatusLabel.InvokeRequired)
            {
                SetStatusTextCallback d = SetDotaStatusText;
                Invoke(d, text);
            }
            else
            {
                dotaStatusLabel.Text = "Status: " + text;
            }
        }

        private delegate void SetStatusTextCallback(string text);

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            _dotaManager.AddCacheHandler(CacheSubscritionTypes.Partyinvite, Test);
        }

        private void Test(CMsgSOCacheSubscribed.SubscribedType subscribedType)
        {
            Console.WriteLine("Received in main!");
        }

        private void ShutdownEvrything()
        {
            // Shutdown manager
            if (_managerThread == null || !_managerThread.IsAlive) return;
            //shutdown dota IF RUNNING (and learn how to use '?')
            _dotaManager?.Stop();
            _steamManager.Stop();
        }
    }
}
