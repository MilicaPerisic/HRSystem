using Client.UIControllers;
using Domain;
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
    public partial class FrmAddActivity : Form
    {
        private UICAddActivity uic = new UICAddActivity();
        public FrmAddActivity()
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

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            uic.AddActivity(txtActivityName, txtNumberOfPoints, cmbCity, cmbTypeOfActivity, rtbActivityDescription);
        }
    }
}
