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
    class UICAddMember
    {
        internal void AddMember(TextBox txtMemberName, TextBox txtMemberSurname, TextBox txtDateOfMembership, TextBox txtNumberOfPoints, ComboBox cmbCity, ComboBox cmbMembershipStatus)
        {
            if(!Validate(txtMemberName, txtMemberSurname, txtDateOfMembership, txtNumberOfPoints ,cmbCity, cmbMembershipStatus))
            {
                MessageBox.Show("Pogresan unos, pokusajte ponovo!");
                return;
            }

            Member member = CreateMember(txtMemberName, txtMemberSurname, txtDateOfMembership, txtNumberOfPoints, cmbCity, cmbMembershipStatus);
            try
            {
                MessageBox.Show(Communication.Instance.AddMember(member));
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da doda clana.");
                return;
            }
        }

        private Member CreateMember(TextBox txtMemberName, TextBox txtMemberSurname, TextBox txtDateOfMembership, TextBox txtNumberOfPoints, ComboBox cmbCity, ComboBox cmbMembershipStatus)
        {
            Member m = new Member();
            m.Name = txtMemberName.Text;
            m.Surname = txtMemberSurname.Text;
            m.DateOfMembership = DateTime.ParseExact(txtDateOfMembership.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
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
            if(cmbCity.SelectedItem is City)
            {
                cmbCity.BackColor = System.Drawing.Color.White;
                return true;
            }
            cmbCity.BackColor = System.Drawing.Color.Red;
            return false;
        }

        private bool ValidateDate(TextBox txtDateOfMembership)
        {
            if (!DateTime.TryParseExact(txtDateOfMembership.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime datum))
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
