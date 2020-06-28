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
    public partial class FrmDeleteMember : Form
    {
        private UICDeleteMember uic = new UICDeleteMember();
        public FrmDeleteMember()
        {
            InitializeComponent();
        }

        private void btnFindMembers_Click(object sender, EventArgs e)
        {
            uic.FindMembers(txtNameToFind, txtSurnameToFind, dgvFoundMembers);
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            uic.DeleteMember(dgvFoundMembers);
        }
    }
}
