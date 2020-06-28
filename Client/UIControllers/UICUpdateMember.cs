using Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UIControllers
{
    class UICUpdateMember
    {
        int memberID;
        internal void FindMembers(TextBox txtNameToFind, TextBox txtSurnameToFind, DataGridView dgvFoundMembers)
        {
            if (!ValidateFind(txtNameToFind, txtSurnameToFind))
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

        internal void ChooseMember(DataGridView dgvFoundMembers, TextBox txtMemberName, TextBox txtMemberSurname, TextBox txtDateOfMembership, TextBox txtNumberOfPoints, ComboBox cmbCity, ComboBox cmbMembershipStatus)
        {
            if (dgvFoundMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali clana. Pokusajte ponovo.");
                return;
            }

            Member member = (Member)dgvFoundMembers.SelectedRows[0].DataBoundItem;
            memberID = member.ID;
            txtMemberName.Text = member.Name;
            txtMemberSurname.Text = member.Surname;
            txtDateOfMembership.Text = Convert.ToString(member.DateOfMembership.Date);
            txtNumberOfPoints.Text = Convert.ToString(member.NumberOfPoints);
            cmbCity.SelectedItem = (City)member.City;
            cmbMembershipStatus.SelectedItem = (MembershipStatus)member.MembershipStatus;

        }

        internal void UpdateMember(TextBox txtMemberName, TextBox txtMemberSurname, TextBox txtDateOfMembership, TextBox txtNumberOfPoints, ComboBox cmbCity, ComboBox cmbMembershipStatus)
        {
            if (!Validate(txtMemberName, txtMemberSurname, txtDateOfMembership, txtNumberOfPoints, cmbCity, cmbMembershipStatus))
            {
                MessageBox.Show("Pogresan unos, pokusajte ponovo!");
                return;
            }

            Member member = CreateMember(txtMemberName, txtMemberSurname, txtDateOfMembership, txtNumberOfPoints, cmbCity, cmbMembershipStatus);
            try
            {
                MessageBox.Show(Communication.Instance.UpdateMember(member));
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da azurira clana.");
                return;
            }
            
        }

        private bool ValidateFind(TextBox txtNameToFind, TextBox txtSurnameToFind)
        {
            int counter = 0;
            if (!ValidateNameFind(txtNameToFind)) counter++;
            if (!ValidateSurnameFind(txtSurnameToFind)) counter++;

            if (counter > 0)
            {
                return false;
            }
            return true;
        }

        private bool ValidateSurnameFind(TextBox txtSurnameToFind)
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

        private bool ValidateNameFind(TextBox txtNameToFind)
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

        private Member CreateMember(TextBox txtMemberName, TextBox txtMemberSurname, TextBox txtDateOfMembership, TextBox txtNumberOfPoints, ComboBox cmbCity, ComboBox cmbMembershipStatus)
        {
            Member m = new Member();
            m.ID = memberID;
            m.Name = txtMemberName.Text;
            m.Surname = txtMemberSurname.Text;
            m.DateOfMembership = DateTime.ParseExact(txtDateOfMembership.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            m.NumberOfPoints = Convert.ToInt32(txtNumberOfPoints.Text);
            m.City = (City)cmbCity.SelectedItem;
            m.MembershipStatus = (MembershipStatus)cmbMembershipStatus.SelectedItem;

            return m;

        }

        private bool Validate(TextBox txtMemberName, TextBox txtMemberSurname, TextBox txtDateOfMembership, TextBox txtNumberOfPoints, ComboBox cmbCity, ComboBox cmbMembershipStatus)
        {
            int counter = 0;
            if (!ValidateName(txtMemberName)) counter++;
            if (!ValidateSurname(txtMemberSurname)) counter++;
            if (!ValidateDate(txtDateOfMembership)) counter++;
            if (!ValidatePoints(txtNumberOfPoints)) counter++;
            if (!ValidateCity(cmbCity)) counter++;
            if (!ValidateStatus(cmbMembershipStatus)) counter++;
            if (counter > 0)
            {
                return false;
            }
            return true;
        }

        private bool ValidatePoints(TextBox txtNumberOfPoints)
        {
            if (!int.TryParse(txtNumberOfPoints.Text, out int value))
            {
                txtNumberOfPoints.BackColor = System.Drawing.Color.Red;
                return false;
            }
            txtNumberOfPoints.BackColor = System.Drawing.Color.White;
            return true;
        }

        private bool ValidateStatus(ComboBox cmbMembershipStatus)
        {
            if (cmbMembershipStatus.SelectedItem is MembershipStatus)
            {
                cmbMembershipStatus.BackColor = System.Drawing.Color.White;
                return true;
            }
            cmbMembershipStatus.BackColor = System.Drawing.Color.Red;
            return false;
        }

        private bool ValidateCity(ComboBox cmbCity)
        {
            if (cmbCity.SelectedItem is City)
            {
                cmbCity.BackColor = System.Drawing.Color.White;
                return true;
            }
            cmbCity.BackColor = System.Drawing.Color.Red;
            return false;
        }

        private bool ValidateDate(TextBox txtDateOfMembership)
        {
            if (!DateTime.TryParseExact(txtDateOfMembership.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime datum))
            {
                txtDateOfMembership.BackColor = System.Drawing.Color.Red;
                txtDateOfMembership.ResetText();
                return false;
            }
            txtDateOfMembership.BackColor = System.Drawing.Color.White;
            return true;
        }

        private bool ValidateSurname(TextBox txtMemberSurname)
        {
            if (txtMemberSurname.Text.Length >= 2 && Regex.IsMatch(txtMemberSurname.Text, @"^[a-zA-Z]+$"))
            {
                txtMemberSurname.BackColor = System.Drawing.Color.White;
                return true;
            }
            txtMemberSurname.BackColor = System.Drawing.Color.Red;
            txtMemberSurname.ResetText();
            return false;
        }

        private bool ValidateName(TextBox txtMemberName)
        {
            if (txtMemberName.Text.Length >= 2 && Regex.IsMatch(txtMemberName.Text, @"^[a-zA-Z]+$"))
            {
                txtMemberName.BackColor = System.Drawing.Color.White;
                return true;
            }
            txtMemberName.BackColor = System.Drawing.Color.Red;
            txtMemberName.ResetText();
            return false;
        }
    }
}
