using Client.UIControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmLogin : Form
    {
        private UICLogin uic = new UICLogin();

        public FrmLogin()
        {
            ConnectToServer();
            InitializeComponent();
        }

        private void ConnectToServer()
        {
            if (Communication.Instance.Connect())
            {
                MessageBox.Show("Povezani ste sa serverom.");
            }
            else
            {
                MessageBox.Show("Niste povezani sa serverom.");
                Environment.Exit(0);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            uic.LoginUser(txtUsername, txtPassword);
        }
    }
}
