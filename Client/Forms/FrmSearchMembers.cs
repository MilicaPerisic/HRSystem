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
    public partial class FrmSearchMembers : Form
    {
        private UICSearchMembers uic = new UICSearchMembers();
        List<string> searchCriteria = new List<string>() { "Ime", "Prezime", "Grad", "Status clanstva" };
        public FrmSearchMembers()
        {
            InitializeComponent();
            cmbSearchCriteria.DataSource = searchCriteria;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFindMembers_Click(object sender, EventArgs e)
        {
            uic.FindMembers(cmbSearchCriteria, txtSearchValue, dgvSearchResults);
        }
    }
}
