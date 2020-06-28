using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Client.UIControllers
{
    class UICAddActivity
    {
        internal void AddActivity(TextBox txtActivityName, TextBox txtNumberOfPoints, ComboBox cmbCity, ComboBox cmbTypeOfActivity, RichTextBox rtbActivityDescription)
        {
            if (!Validate(txtActivityName, txtNumberOfPoints, cmbCity, cmbTypeOfActivity, rtbActivityDescription))
            {
                MessageBox.Show("Pogresan unos, pokusajte ponovo!");
                return;
            }


            Activity activity= CreateActivity(txtActivityName, txtNumberOfPoints, cmbCity, cmbTypeOfActivity, rtbActivityDescription);
            try
            {
                MessageBox.Show(Communication.Instance.AddActivity(activity));
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da doda aktivnost.");
                return;
            }
            
        }

        private Activity CreateActivity(TextBox txtActivityName, TextBox txtNumberOfPoints, ComboBox cmbCity, ComboBox cmbTypeOfActivity, RichTextBox rtbActivityDescription)
        {
            Activity a = new Activity();
            a.Name = txtActivityName.Text;
            a.NumberOfPoints = Convert.ToInt32(txtNumberOfPoints.Text);
            a.City = (City)cmbCity.SelectedItem;
            a.Type = (TypeOfActivity)cmbTypeOfActivity.SelectedItem;
            a.Description = rtbActivityDescription.Text;

            return a;
        }

        private bool Validate(TextBox txtActivityName, TextBox txtNumberOfPoints, ComboBox cmbCity, ComboBox cmbTypeOfActivity, RichTextBox rtbActivityDescription)
        {
            int counter = 0;
            if (!ValidateName(txtActivityName)) counter++;
            if (!ValidatePoints(txtNumberOfPoints)) counter++;
            if (!ValidateCity(cmbCity)) counter++;
            if (!ValidateType(cmbTypeOfActivity)) counter++;
            if (!ValidateDescription(rtbActivityDescription)) counter++;
            if (counter > 0)
            {
                return false;
            }
            return true;
        }

        private bool ValidateDescription(RichTextBox rtbActivityDescription)
        {
            if (rtbActivityDescription.Text.Length >= 2 && Regex.IsMatch(rtbActivityDescription.Text, @"^[a-zA-Z0-9_]+$"))
            {
                rtbActivityDescription.BackColor = System.Drawing.Color.White;
                return true;
            }
            rtbActivityDescription.BackColor = System.Drawing.Color.Red;
            rtbActivityDescription.ResetText();
            return false;
        }

        private bool ValidateType(ComboBox cmbTypeOfActivity)
        {
            if (cmbTypeOfActivity.SelectedItem is TypeOfActivity)
            {
                cmbTypeOfActivity.BackColor = System.Drawing.Color.White;
                return true;
            }
            cmbTypeOfActivity.BackColor = System.Drawing.Color.Red;
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

        private bool ValidateName(TextBox txtActivityName)
        {
            if (txtActivityName.Text.Length >= 2 && Regex.IsMatch(txtActivityName.Text, @"^[a-zA-Z0-9_]+$"))
            {
                txtActivityName.BackColor = System.Drawing.Color.White;
                return true;
            }
            txtActivityName.BackColor = System.Drawing.Color.Red;
            txtActivityName.ResetText();
            return false;
        }
    }
}
