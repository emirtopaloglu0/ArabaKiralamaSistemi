using AracKiralama.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracKiralama.Properties;

namespace AracKiralama.View
{

    public partial class LoginPanel : UserControl
    {


        public LoginPanel()
        {

            InitializeComponent();
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            if(Musteri.MusteriClass.GirisYap(Username_Textbox.Text, Password_Textbox.Text))
            {
                try
                {
                    UserPanel.instance.loggedUser = Username_Textbox.Text;
                    Username_Textbox.Text = "";
                    Password_Textbox.Text = "";
                    Settings.Default.Logged = true;
                    UserPanel.instance.LoggedIn();
                    Settings.Default.Save();
                }
                catch
                {
                    throw new InvalidProgramException();
                }
                
            }
            
        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {

        }

        private void Register_Btn_Click(object sender, EventArgs e)
        {
           KayitForm form = new KayitForm();
           form.ShowDialog();

            
        }

        private void Username_Textbox_TextChanged(object sender, EventArgs e)
        {
            char[] charsToTrim = Form1.instance.charsToTrim;

            Username_Textbox.Text = Username_Textbox.Text.Trim(charsToTrim);
            Username_Textbox.SelectionStart = Username_Textbox.Text.Length;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Password_Textbox.PasswordChar = '\0';
            }
            else
            {
                Password_Textbox.PasswordChar = '*';

            }
        }

        private void Password_Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                Login_Btn_Click(sender, e);
            }
        }
    }
}
