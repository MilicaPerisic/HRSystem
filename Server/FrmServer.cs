using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server s;
        Thread serverThread;
        public FrmServer()
        {
            InitializeComponent();
            btnStop.Enabled = false;
        }

        

        private void btnRun_Click_1(object sender, EventArgs e)
        {
            s = new Server();
            if (s.RunServer())
            {
                serverThread = new Thread(s.Listen);
                serverThread.IsBackground = true;
                serverThread.Start();
                MessageBox.Show("Server je pokrenut.");
                btnRun.Enabled = false;
                btnStop.Enabled = true;
            }
            else
            {
                MessageBox.Show("Server nije pokrenut.");
            }
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            if (Server.connectedClients.Count > 0)
            {
                MessageBox.Show("Postoji još ulogovanih klijenata!");
                return;
            }
            if (s.StopServer())
            {
                MessageBox.Show("Server je zaustavljen.");
                btnRun.Enabled = true;
                btnStop.Enabled = false;
            }

        }
    }
}
