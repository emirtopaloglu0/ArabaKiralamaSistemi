using AracKiralama.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama.View.UserView
{
    public partial class U_Ayarlar : UserControl
    {
        public U_Ayarlar()
        {
            InitializeComponent();
        }

        private void ChangePass_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(Musteri.MusteriClass.SifreDegistir(UserPanel.instance.loggedUser, OldPass_Textbox.Text, NewPass_TextBox.Text))
                {
                    BasariliMesajlar.SifreDegistirme();
                    OldPass_Textbox.Text = "";
                    NewPass_TextBox.Text = "";
                }
            }
            catch
            {

            }
        }

        private void ChangeUser_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Musteri.MusteriClass.KullaniciAdiDegistir(UserPanel.instance.loggedUser, newUser_TextBox.Text))
                {
                    UserPanel.instance.loggedUser = newUser_TextBox.Text;
                    BasariliMesajlar.KullaniciDegistirme();
                }
            }
            catch
            {

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                OldPass_Textbox.PasswordChar = '\0';
                NewPass_TextBox.PasswordChar = '\0';
            }
            else
            {
                NewPass_TextBox.PasswordChar = '*';
                OldPass_Textbox.PasswordChar = '*';
            }
        }

        private void newUser_TextBox_TextChanged(object sender, EventArgs e)
        {
            char[] charsToTrim = Form1.instance.charsToTrim;

            newUser_TextBox.Text = newUser_TextBox.Text.Trim(charsToTrim);
            newUser_TextBox.SelectionStart = newUser_TextBox.Text.Length;
        }
    }
}
