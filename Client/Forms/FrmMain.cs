using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddMember addMember = new FrmAddMember();
                addMember.ShowDialog();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pokrene operaciju.");
                return;
            }
            
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUpdateMember updateMember = new FrmUpdateMember();
                updateMember.ShowDialog();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pokrene operaciju.");
                return;
            }
            
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDeleteMember deleteMember = new FrmDeleteMember();
                deleteMember.ShowDialog();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pokrene operaciju.");
                return;
            }
            

        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSearchMembers searchMembers = new FrmSearchMembers();
                searchMembers.ShowDialog();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pokrene operaciju.");
                return;
            }
            
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddActivity addActivity = new FrmAddActivity();
                addActivity.ShowDialog();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pokrene operaciju.");
                return;
            }
            
        }

        private void btnUpdateActivity_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUpdateActivity updateActivity = new FrmUpdateActivity();
                updateActivity.ShowDialog();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pokrene operaciju.");
                return;
            }
            
        }

        private void btnAddEngagement_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddEngagement addEngagement = new FrmAddEngagement();
                addEngagement.ShowDialog();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pokrene operaciju.");
                return;
            }
            
        }
    }
}
