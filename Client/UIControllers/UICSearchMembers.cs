using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UIControllers
{
    class UICSearchMembers
    {
        internal void FindMembers(ComboBox cmbSearchCriteria, TextBox txtSearchValue, DataGridView dgvSearchResults)
        {
            if (!Validate(cmbSearchCriteria, txtSearchValue))
            {
                MessageBox.Show("Pogresan unos, pokusajte ponovo!");
                return;
            }
            Member member = CreateMember(cmbSearchCriteria, txtSearchValue);
            try
            {
                dgvSearchResults.DataSource = Communication.Instance.FindMembers(member);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da doda aktivnost.");
                return;
            }
            
        }

        private bool Validate(ComboBox cmbSearchCriteria, TextBox txtSearchValue)
        {
            int counter = 0;
            if (!ValidateCriteria(cmbSearchCriteria)) counter++;
            if (!ValidateValue(txtSearchValue)) counter++;

            if (counter > 0)
            {
                return false;
            }
            return true;
        }

        private bool ValidateValue(TextBox txtSearchValue)
        {
            if (txtSearchValue.Text.Length >= 2 && Regex.IsMatch(txtSearchValue.Text, @"^[a-zA-Z]+$"))
            {
                txtSearchValue.BackColor = System.Drawing.Color.White;
                return true;
            }
            txtSearchValue.BackColor = System.Drawing.Color.Red;
            txtSearchValue.ResetText();
            return false;
        }

        private bool ValidateCriteria(ComboBox cmbSearchCriteria)
        {
            if (cmbSearchCriteria.SelectedItem is null)
            {
                cmbSearchCriteria.BackColor = System.Drawing.Color.Red;
                return false;
                
            }
            cmbSearchCriteria.BackColor = System.Drawing.Color.White;
            return true;
        }

        private Member CreateMember(ComboBox cmbSearchCriteria, TextBox txtSearchValue)
        {
            Member m = new Member();
            if(cmbSearchCriteria.SelectedItem.ToString() == "Ime")
            {
                m.SearchWhere = $"where m.Name = '{txtSearchValue.Text}'";
            }
            if (cmbSearchCriteria.SelectedItem.ToString() == "Prezime")
            {
                m.SearchWhere = $"where m.Surname = '{txtSearchValue.Text}'";
            }
            if (cmbSearchCriteria.SelectedItem.ToString() == "Grad")
            {
                m.SearchWhere = $"where c.Name = '{txtSearchValue.Text}'";
            }
            if (cmbSearchCriteria.SelectedItem.ToString() == "Status clanstva")
            {
                m.SearchWhere = $"where ms.Name = '{txtSearchValue.Text}'";
            }

            return m;
        }
    }
}
