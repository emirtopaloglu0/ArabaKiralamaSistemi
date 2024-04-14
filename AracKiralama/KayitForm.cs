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
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AracKiralama
{
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Register_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                

                var today = DateTime.Today;


                var age = today.Year - dateTimePicker1.Value.Year;
                if (dateTimePicker1.Value.Date > today.AddYears(-age))
                {
                    age--;
                }

                var licance = today.Year - dateTimePicker2.Value.Year;
                if (dateTimePicker2.Value.Date > today.AddYears(-licance))
                {
                    licance--;
                }



                if (age >= 18)
                {
                    if (licance > 1)
                    {
                        if (Username_Textbox.Text == "" || Password_Textbox.Text == "")
                        {
                            HataMesajlari.BosOlamaz();
                        }
                        else
                        {
                            if (Username_Textbox.Text == "admin" || Password_Textbox.Text == "admin")
                            {
                                HataMesajlari.AdminKayitHata();
                            }
                            else
                            {
                                Musteri.MusteriClass.KayitOl(Username_Textbox.Text, Password_Textbox.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                                Close();
                            }
                        }
                    }
                    else
                    {
                        HataMesajlari.EhliyetYiliYetersiz();
                    }
                }
                else
                {
                    HataMesajlari.YasYetersiz();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void KayitForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogMesjalar.instance.RegisterExit();
            //DialogResult res = MessageBox.Show("İptal Etmek İstediğinze Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogMesjalar.instance.res == DialogResult.Yes)
            {
                Close();
            }
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

        private void Username_Textbox_TextChanged(object sender, EventArgs e)
        {
            char[] charsToTrim = Form1.instance.charsToTrim;

            Username_Textbox.Text = Username_Textbox.Text.Trim(charsToTrim);
            Username_Textbox.SelectionStart = Username_Textbox.Text.Length;
        }
    }
}
