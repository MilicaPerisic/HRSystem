using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UIControllers
{
    class UICAddEngagement
    {
        BindingList<Member> members = new BindingList<Member>();
        Engagement engagement = new Engagement();

        internal void AddMember(DataGridView dgvFoundMembers, DataGridView dgvMembers)
        {
            if (dgvFoundMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali clana kojeg zelite da dodate!");
                return;
            }
            Member member = (Member)dgvFoundMembers.SelectedRows[0].DataBoundItem;
            if (members.Contains(member))
            {
                MessageBox.Show("Vec ste uneli tog clana!");
                return;
            }
            members.Add(member);
            dgvMembers.DataSource = members;
        }

        

        internal void DeleteMember(DataGridView dgvMembers)
        {
            if (members.Count == 0)
            {
                MessageBox.Show("Ne postoji clan kojeg mozete da obrisete!");
                return;
            }

            if (dgvMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali clana kojeg zelite da obrisete!");
                return;
            }

            Member deleteMember = (Member)dgvMembers.SelectedRows[0].DataBoundItem;
            members.Remove(deleteMember);
            dgvMembers.DataSource = members;
        }

        internal void AddEngagement(TextBox txtStartDate, DataGridView dgvMembers)
        {
            
            if (!ValidateEngagement(engagement.Activity, txtStartDate, members, dgvMembers))
            {
                MessageBox.Show("Pogresan unos, pokusajte ponovo!");

                return;
            }
            
            CreateEngagement(txtStartDate, members);
            
            try
            {
                if (!UniqueEngagement(engagement, out string name))
                {
                    MessageBox.Show("Angazovanje za clana " + name + " vec postoji!");

                    return;
                }
                MessageBox.Show(Communication.Instance.AddEngagement(engagement));
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da unese angazovanje.");
                return;
            }
            
        }

        private bool UniqueEngagement(Engagement engagement, out string name)
        {
            
            List<EngagementHelper> engagements = Communication.Instance.ReturnEngagements();
            
            foreach (Member m in engagement.Members)
            {
                engagement.Member = m;
                foreach (EngagementHelper e in engagements)
                {
                    if(engagement.Member.ID == e.MemberID && engagement.Activity.ID == e.ActivityID && engagement.StartDate == e.StartDate)
                    {
                        name = engagement.Member.ToString();
                        return false;
                    }
                }



            }
            name = "";
            return true;
        }

        internal void FindMembers(TextBox txtNameToFind, TextBox txtSurnameToFind, DataGridView dgvFoundMembers)
        {
            if (!ValidateFindMember(txtNameToFind, txtSurnameToFind))
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
                dgvFoundMembers.DataSource = Communication.Instance.FindMembers(member);
                return;
            }
            
        }

        private Member CreateMember(TextBox txtNameToFind, TextBox txtSurnameToFind)
        {
            Member m = new Member();
            m.SearchWhere = $"where (m.Name = '{txtNameToFind.Text}') and (m.Surname = '{txtSurnameToFind.Text}')";
            return m;
        }

        private bool ValidateFindMember(TextBox txtNameToFind, TextBox txtSurnameToFind)
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

        internal void ChooseActivity(DataGridView dgvFoundActivities)
        {
            if (dgvFoundActivities.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali aktivnost. Pokusajte ponovo.");
                return;
            }

            Activity activity = (Activity)dgvFoundActivities.SelectedRows[0].DataBoundItem;
            engagement.Activity = activity;
            MessageBox.Show("Aktivnost izabrana.");
           
        }

        internal void FindActivities(TextBox txtActivityNameToFind, DataGridView dgvFoundActivities)
        {
            
            if (!ValidateFindActivity(txtActivityNameToFind))
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

        private Activity CreateActivity(TextBox txtActivityNameToFind)
        {
            Activity a = new Activity();
            a.SearchWhere = $"where (a.Name = '{txtActivityNameToFind.Text}')";
            return a;
        }

        private bool ValidateFindActivity(TextBox txtActivityNameToFind)
        {
            int counter = 0;
            if (!ValidateActivityNameFind(txtActivityNameToFind)) counter++;

            if (counter > 0)
            {
                return false;
            }
            return true;
        }

        private bool ValidateActivityNameFind(TextBox txtActivityNameToFind)
        {
            if (txtActivityNameToFind.Text.Length >= 2 && Regex.IsMatch(txtActivityNameToFind.Text, @"^[a-zA-Z]+$"))
                {
                    txtActivityNameToFind.BackColor = System.Drawing.Color.White;
                    return true;
                }
                txtActivityNameToFind.BackColor = System.Drawing.Color.Red;
                txtActivityNameToFind.ResetText();
                return false;
            

        }
        
       

        private void CreateEngagement(TextBox txtStartDate, BindingList<Member> members)
        {
            
            engagement.StartDate = DateTime.ParseExact(txtStartDate.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            engagement.Members = members.ToList();
        }

        private bool ValidateEngagement(Activity activity, TextBox txtStartDate, BindingList<Member> members, DataGridView dgvMembers)
        {
            int counter = 0;
            if (!ValidateActivity(activity)) counter++;
            if (!ValidateDate(txtStartDate)) counter++;
            if (!ValidateMembers(members, dgvMembers)) counter++;
            
            if (counter > 0)
            {
                return false;
            }
            return true;
        }

        private bool ValidateMembers(BindingList<Member> members, DataGridView dgvMembers)
        {
            if (members.Count == 0)
            {
                dgvMembers.BackColor = System.Drawing.Color.Red;
                return false;
            }
            dgvMembers.BackColor = System.Drawing.Color.White;
            return true;
        }

        private bool ValidateDate(TextBox txtStartDate)
        {
            if (!DateTime.TryParseExact(txtStartDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                txtStartDate.BackColor = System.Drawing.Color.Red;
                txtStartDate.ResetText();
                return false;
            }
            Console.WriteLine(date);
            if(date < DateTime.Today)
            {

                txtStartDate.BackColor = System.Drawing.Color.Red;
                txtStartDate.ResetText();
                return false;
            }
            return true;
        }

        private bool ValidateActivity(Activity activity)
        {
            if (activity is Activity)
            {
                return true;
            }

            return false;
        }
    }
}
