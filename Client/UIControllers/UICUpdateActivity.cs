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
    class UICUpdateActivity
    {
        int activityID;
        internal void FindActivities(TextBox txtActivityNameToFind, DataGridView dgvFoundActivities)
        {
   
            if (!ValidateFind(txtActivityNameToFind))
            {
                MessageBox.Show("Pogresan unos, pokusajte ponovo!");
                return;
            }
            Activity activity = CreateActivity(txtActivityNameToFind);
            try
            {
                dgvFoundActivities.DataSource = Communication.Instance.FindActivities(activity);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pronadje aktivnost.");
                return;
            }
            
        }

        private bool ValidateFind(TextBox txtActivityNameToFind)
        {
            int counter = 0;
            if (!ValidateNameFind(txtActivityNameToFind)) counter++;

            if (counter > 0)
            {
                return false;
            }
            return true;
        }

        internal void ChooseActivity(DataGridView dgvFoundActivities, TextBox txtActivityName, TextBox txtNumberOfPoints, ComboBox cmbCity, ComboBox cmbTypeOfActivity, RichTextBox rtbActivityDescription)
        {
            if (dgvFoundActivities.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali aktivnost. Pokusajte ponovo.");
                return;
            }

            Activity activity = (Activity)dgvFoundActivities.SelectedRows[0].DataBoundItem;
            activityID = activity.ID;
            txtActivityName.Text = activity.Name;
            txtNumberOfPoints.Text = Convert.ToString(activity.NumberOfPoints);
            cmbCity.SelectedItem = (City)activity.City;
            cmbTypeOfActivity.SelectedItem = (TypeOfActivity)activity.Type;
            rtbActivityDescription.Text = activity.Description;
        }

        internal void UpdateActivity(TextBox txtActivityName, TextBox txtNumberOfPoints, ComboBox cmbCity, ComboBox cmbTypeOfActivity, RichTextBox rtbActivityDescription)
        {
            if (!Validate(txtActivityName, txtNumberOfPoints, cmbCity, cmbTypeOfActivity, rtbActivityDescription))
            {
                MessageBox.Show("Pogresan unos, pokusajte ponovo!");
                return;
            }

            Activity activity = CreateActivity(txtActivityName, txtNumberOfPoints, cmbCity, cmbTypeOfActivity, rtbActivityDescription);
            try
            {
                MessageBox.Show(Communication.Instance.UpdateActivity(activity));
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da azurira aktivnost.");
                return;
            }
            
        }

        private Activity CreateActivity(TextBox txtActivityName, TextBox txtNumberOfPoints, ComboBox cmbCity, ComboBox cmbTypeOfActivity, RichTextBox rtbActivityDescription)
        {
            Activity a = new Activity();
            a.ID = activityID;
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

        private bool ValidateNameFind(TextBox txtActivityNameToFind)
        {
            if (txtActivityNameToFind.Text.Length >= 2 && Regex.IsMatch(txtActivityNameToFind.Text, @"^[a-zA-Z0-9]+$"))
            {
                txtActivityNameToFind.BackColor = System.Drawing.Color.White;
                return true;
            }
            txtActivityNameToFind.BackColor = System.Drawing.Color.Red;
            txtActivityNameToFind.ResetText();
            return false;
        }

        private Activity CreateActivity(TextBox txtActivityNameToFind)
        {
            Activity a = new Activity();
            a.SearchWhere = $"where (a.Name = '{txtActivityNameToFind.Text}')";
            return a;
        }
    }
}
