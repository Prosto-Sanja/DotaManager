using System;
using System.Threading;
using System.Windows.Forms;
using DotaManager.Data_Classes.Enums;

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
                _exceptionThread = new Thread(MonitorError);
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

        private void MonitorError()
        {
            try
            {
                ManagerStatus status;
                while ((status = _steamManager.Monitor()) != ManagerStatus.Stopped)
                {
                    SetStatusText(status.ToString());
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
                SetStatusText(ManagerStatus.Stopped.ToString());
            }
            catch (Exception exception)
            {
                SetStatusText(ManagerStatus.Exception.ToString());
                MessageBox.Show(exception.GetType().ToString());
            }
        }

        #region thread safe GUI calls
        private void SetStatusText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (playGroup.InvokeRequired)
            {
                SetTextCallback d = SetStatusText;
                Invoke(d, text);
            }
            else
            {
                playGroup.Text = "Status: " + text;
            }
        }

        private delegate void SetTextCallback(string text);

        #endregion

        private void ShutdownEvrything()
        {
            // Shutdown manager
            if (_managerThread == null || !_managerThread.IsAlive) return;
            _steamManager.Stop();
            _dotaManager = null;
            _steamManager = null;
        }
    }
}
