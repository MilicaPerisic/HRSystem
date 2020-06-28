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

namespace Client.Forms
{
    public partial class FrmUpdateMember : Form
    {
        private UICUpdateMember uic = new UICUpdateMember();
        public FrmUpdateMember()
        {
            InitializeComponent();
            try
            {
                cmbCity.DataSource = Communication.Instance.ReturnCities();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da ucita gradove.");
                return;
            }
            try
            {
                cmbMembershipStatus.DataSource = Communication.Instance.ReturnMembershipStatuses();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da ucita statuse clanstva.");
                return;
            }
        }

        private void btnFindMembers_Click(object sender, EventArgs e)
        {
            uic.FindMembers(txtNameToFind, txtSurnameToFind, dgvFoundMembers);
        }

        private void btnSelectMember_Click(object sender, EventArgs e)
        {
            uic.ChooseMember(dgvFoundMembers, txtMemberName, txtMemberSurname, txtDateOfMembership, txtNumberOfPoints, cmbCity,cmbMembershipStatus);
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            uic.UpdateMember(txtMemberName, txtMemberSurname, txtDateOfMembership, txtNumberOfPoints, cmbCity, cmbMembershipStatus);
        }
    }
}
