using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Forms;
using Domain;
namespace Client.UIControllers
{
    class UICLogin
    {
        internal void LoginUser(TextBox txtUsername, TextBox txtPassword)
        {
            User u = new User();
            u.Username = txtUsername.Text;
            u.Password = txtPassword.Text;

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Nista uneli korisnicko ime ili sifru.");
                return;
            }
            try
            {
                if (!Communication.Instance.LoginUser(u))
                {
                    MessageBox.Show($"Pogresno ste uneli korisnicko ime ili sifru! Pokusajte ponovo.");
                    txtUsername.ResetText();
                    txtPassword.ResetText();
                    return;

                }
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da prijavi clana.");
                return;
            }

            MessageBox.Show($"Uspesno ste ste prijavili! Dobrodosli {txtUsername.Text}!");
            FrmMain main = new FrmMain();
            main.ShowDialog();


        }
    }
}
