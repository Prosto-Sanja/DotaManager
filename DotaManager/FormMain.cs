using System;
using System.Windows.Forms;
using DotaManager.Data_Classes.Exceptions;

namespace DotaManager
{
    public partial class FormMain : Form
    {
        private Manager _manager;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                _manager = new Manager("", "");
                var myThread = new System.Threading.Thread(_manager.Start);
                myThread.Start();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.GetType().ToString());
            }


        }

        private void FormMain_Closing(object sender, FormClosingEventArgs eventArgs)
        {
            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    eventArgs.Cancel = true;
                    break;
                default:
                    _manager.Stop();
                    break;
            }
        }
    }
}
