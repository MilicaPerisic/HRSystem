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
    public partial class FrmUpdateActivity : Form
    {
        private UICUpdateActivity uic = new UICUpdateActivity();
        public FrmUpdateActivity()
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
                cmbTypeOfActivity.DataSource = Communication.Instance.ReturnTypes();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da ucita tipove aktivnosti.");
                return;
            }
        }

        private void btnFindActivities_Click(object sender, EventArgs e)
        {
            uic.FindActivities(txtActivityNameToFind, dgvFoundActivities);
        }

        private void btnSelectActivity_Click(object sender, EventArgs e)
        {
            uic.ChooseActivity(dgvFoundActivities, txtActivityName, txtNumberOfPoints, cmbCity, cmbTypeOfActivity, rtbActivityDescription);
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            uic.UpdateActivity(txtActivityName, txtNumberOfPoints, cmbCity, cmbTypeOfActivity, rtbActivityDescription);
        }
    }
}
