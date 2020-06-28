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
    public partial class FrmAddMember : Form
    {
        private UICAddMember uic = new UICAddMember();
        public FrmAddMember()
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

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            uic.AddMember(txtMemberName, txtMemberSurname, txtDateOfMembership, txtNumberOfPoints, cmbCity, cmbMembershipStatus);
        }
    }
}
