using System;
using System.Threading;
using System.Windows.Forms;
using DotaManager.Data_Classes.Exceptions;

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
                _exceptionThread = new Thread(monitorError);
                _exceptionThread.Start();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.GetType().ToString());
            }
        }

        private void monitorError()
        {
            while (_manager.IsRunning())
            {
                try
                {
                    _manager.MonitorException();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.GetType().ToString());
                }
            }
        }
    }
}
