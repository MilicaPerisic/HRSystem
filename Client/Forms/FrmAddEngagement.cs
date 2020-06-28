using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.UIControllers;
using Domain;

namespace Client.Forms
{
    public partial class FrmAddEngagement : Form
    {
        private UICAddEngagement uic = new UICAddEngagement();
        
        public FrmAddEngagement()
        {
            InitializeComponent();
            dgvFoundActivities.DataSource = new BindingList<Activity>();
            dgvFoundMembers.DataSource = new BindingList<Member>();
            dgvMembers.DataSource = new BindingList<Member>();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            uic.AddMember(dgvFoundMembers, dgvMembers);
           
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            uic.DeleteMember(dgvMembers);
        }

        private void btnAddEngagement_Click(object sender, EventArgs e)
        {
            uic.AddEngagement(txtStartDate, dgvMembers);
        }

        private void FrmAddEngagement_Load(object sender, EventArgs e)
        {

        }

        private void btnFindActivities_Click(object sender, EventArgs e)
        {
            uic.FindActivities(txtActivityNameToFind, dgvFoundActivities);
        }

        private void btnSelectActivity_Click(object sender, EventArgs e)
        {
            uic.ChooseActivity(dgvFoundActivities);
        }

        private void btnFindMembers_Click(object sender, EventArgs e)
        {
            uic.FindMembers(txtNameToFind, txtSurnameToFind, dgvFoundMembers);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
