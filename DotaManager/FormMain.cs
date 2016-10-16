using System;
using System.Threading;
using System.Windows.Forms;
using DotaManager.Data_Classes.Enums;

namespace DotaManager
{
    public partial class FormMain : Form
    {
        private Thread _managerThread, _exceptionThread;
        private Manager _manager;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_Closing(object sender, FormClosingEventArgs eventArgs)
        {
            // Shutdown manager
            if (_managerThread != null && _managerThread.IsAlive)
            {
                _manager.Stop();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                _manager = new Manager(usernameBox.Text, passwordBox.Text);
                _managerThread = new Thread(_manager.Start);
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
            // Shutdown manager
            if (_managerThread != null && _managerThread.IsAlive)
            {
                _manager.Stop();
            }
        }

        private void MonitorError()
        {
            try
            {
                ManagerStatus status;
                while ((status = _manager.Monitor()) != ManagerStatus.Stopped)
                {
                    Console.WriteLine(status);
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.GetType().ToString());
            }

        }
    }
}
