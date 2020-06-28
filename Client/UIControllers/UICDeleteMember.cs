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
    class UICDeleteMember
    {
        internal void FindMembers(TextBox txtNameToFind, TextBox txtSurnameToFind, DataGridView dgvFoundMembers)
        {
            if (!Validate(txtNameToFind, txtSurnameToFind))
            {
                MessageBox.Show("Pogresan unos, pokusajte ponovo!");
                return;
            }
            Member member = CreateMember(txtNameToFind, txtSurnameToFind);
            try
            {
                dgvFoundMembers.DataSource = Communication.Instance.FindMembers(member);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pronadje clana.");
                return;
            }
            
            
            
        }

        internal void DeleteMember(DataGridView dgvFoundMembers)
        {
            if(dgvFoundMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali clana. Pokusajte ponovo.");
                
                return;
            }
            Member member = (Member)dgvFoundMembers.SelectedRows[0].DataBoundItem;
            Console.WriteLine(member.ID);
            try
            {
                MessageBox.Show(Communication.Instance.DeleteMember(member));
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da obrise clana.");
                return;
            }
            
        }

        private bool Validate(TextBox txtNameToFind, TextBox txtSurnameToFind)
        {
            int counter = 0;
            if (!ValidateName(txtNameToFind)) counter++;
            if (!ValidateSurname(txtSurnameToFind)) counter++;
            
            if (counter > 0)
            {
                return false;
            }
            return true;
        }

        private bool ValidateSurname(TextBox txtSurnameToFind)
        {
            if (txtSurnameToFind.Text.Length >= 2 && Regex.IsMatch(txtSurnameToFind.Text, @"^[a-zA-Z]+$"))
            {
                txtSurnameToFind.BackColor = System.Drawing.Color.White;
                return true;
            }
            txtSurnameToFind.BackColor = System.Drawing.Color.Red;
            txtSurnameToFind.ResetText();
            return false;
        }

        private bool ValidateName(TextBox txtNameToFind)
        {
            if (txtNameToFind.Text.Length >= 2 && Regex.IsMatch(txtNameToFind.Text, @"^[a-zA-Z]+$"))
            {
                txtNameToFind.BackColor = System.Drawing.Color.White;
                return true;
            }
            txtNameToFind.BackColor = System.Drawing.Color.Red;
            txtNameToFind.ResetText();
            return false;
        }

        private Member CreateMember(TextBox txtNameToFind, TextBox txtSurnameToFind)
        {
            Member m = new Member();
            m.SearchWhere = $"where (m.Name = '{txtNameToFind.Text}') and (m.Surname = '{txtSurnameToFind.Text}')";
            return m;
        }

        
    }
}
