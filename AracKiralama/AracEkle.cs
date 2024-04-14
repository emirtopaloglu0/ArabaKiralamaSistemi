using AracKiralama.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class AracEkle : Form
    {
        public AracEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogMesjalar.instance.RegisterExit();

            if (DialogMesjalar.instance.res == DialogResult.Yes)
            {
                Close();
            }
        }



        private void MarkaBox_SelectecIndexChange(object sender, EventArgs e)
        {
            try
            {
                ModelBox.Items.Clear();

                if (MarkaBox.SelectedItem == "Volvo")
                {
                    ModelBox.Items.Add("S60");
                    ModelBox.Items.Add("S90");
                    ModelBox.Items.Add("V40");
                    ModelBox.Items.Add("V60");
                    ModelBox.Items.Add("V90");
                    ModelBox.Items.Add("XC40");
                    ModelBox.Items.Add("XC60");
                    ModelBox.Items.Add("XC90");
                }

                else if (MarkaBox.SelectedItem == "Volkswagen")
                {
                    ModelBox.Items.Add("Polo");
                    ModelBox.Items.Add("Golf");
                    ModelBox.Items.Add("Passat");
                    ModelBox.Items.Add("Taigo");
                    ModelBox.Items.Add("Tiguan");
                }

                else if (MarkaBox.SelectedItem == "Toyota")
                {
                    ModelBox.Items.Add("Corolla");
                    ModelBox.Items.Add("Yaris");
                    ModelBox.Items.Add("RAV4");
                    ModelBox.Items.Add("Hilux");
                    ModelBox.Items.Add("Auris");
                    ModelBox.Items.Add("Avensis");
                }

                else if (MarkaBox.SelectedItem == "Skoda")
                {
                    ModelBox.Items.Add("Fabia");
                    ModelBox.Items.Add("Scala");
                    ModelBox.Items.Add("Octavia");
                    ModelBox.Items.Add("Superb");
                    ModelBox.Items.Add("Kamiq");
                    ModelBox.Items.Add("Karoq");
                    ModelBox.Items.Add("Kodiaq");
                    ModelBox.Items.Add("Citigo");
                }

                else if (MarkaBox.SelectedItem == "Seat")
                {
                    ModelBox.Items.Add("Ibiza");
                    ModelBox.Items.Add("Leon");
                    ModelBox.Items.Add("Arona");
                    ModelBox.Items.Add("Ateca");
                    ModelBox.Items.Add("Altea");
                    ModelBox.Items.Add("Cordoba");
                    ModelBox.Items.Add("Toledo");
                }

                else if (MarkaBox.SelectedItem == "Peugeot")
                {
                    ModelBox.Items.Add("208");
                    ModelBox.Items.Add("2008");
                    ModelBox.Items.Add("308");
                    ModelBox.Items.Add("3008");
                    ModelBox.Items.Add("408");
                    ModelBox.Items.Add("4008");
                    ModelBox.Items.Add("508");
                    ModelBox.Items.Add("5008");
                }

                else if (MarkaBox.SelectedItem == "Opel")
                {
                    ModelBox.Items.Add("Corsa");
                    ModelBox.Items.Add("Astra");
                    ModelBox.Items.Add("Mokka");
                    ModelBox.Items.Add("Crossland");
                    ModelBox.Items.Add("Grandland");
                    ModelBox.Items.Add("Combo");
                    ModelBox.Items.Add("Zafira");
                    ModelBox.Items.Add("Insignia");
                }

                else if (MarkaBox.SelectedItem == "Nissan")
                {
                    ModelBox.Items.Add("Juke");
                    ModelBox.Items.Add("Qashqai");
                    ModelBox.Items.Add("X-Trail");
                    ModelBox.Items.Add("Micra");
                    ModelBox.Items.Add("Navara");
                    ModelBox.Items.Add("Note");
                    ModelBox.Items.Add("Primera");
                    ModelBox.Items.Add("Pulsar");
                }

                else if (MarkaBox.SelectedItem == "Mercedes")
                {
                    ModelBox.Items.Add("A Serisi");
                    ModelBox.Items.Add("B Serisi");
                    ModelBox.Items.Add("C Serisi");
                    ModelBox.Items.Add("CLA Serisi");
                    ModelBox.Items.Add("CLS");
                    ModelBox.Items.Add("E Serisi");
                    ModelBox.Items.Add("GLA Serisi");
                    ModelBox.Items.Add("Vito");
                }

                else if (MarkaBox.SelectedItem == "Hyundai")
                {
                    ModelBox.Items.Add("i10");
                    ModelBox.Items.Add("i20");
                    ModelBox.Items.Add("Bayon");
                    ModelBox.Items.Add("Kona");
                    ModelBox.Items.Add("Elantra");
                    ModelBox.Items.Add("Ioniq 5");
                    ModelBox.Items.Add("Tucson");
                    ModelBox.Items.Add("Accent");
                    ModelBox.Items.Add("Getz");
                    ModelBox.Items.Add("i30");
                }

                else if (MarkaBox.SelectedItem == "Honda")
                {
                    ModelBox.Items.Add("Civic");
                    ModelBox.Items.Add("City");
                    ModelBox.Items.Add("Accord");
                    ModelBox.Items.Add("Jazz");
                    ModelBox.Items.Add("HR-V");
                    ModelBox.Items.Add("CR-V");
                    ModelBox.Items.Add("CR-Z");
                    ModelBox.Items.Add("ZR-V");
                }

                else if (MarkaBox.SelectedItem == "Fiat")
                {
                    ModelBox.Items.Add("Egea");
                    ModelBox.Items.Add("Fiorino");
                    ModelBox.Items.Add("Doblo");
                    ModelBox.Items.Add("Linea");
                    ModelBox.Items.Add("Albea");
                    ModelBox.Items.Add("Palio");
                    ModelBox.Items.Add("Punto");
                    ModelBox.Items.Add("500L");
                }

                else if (MarkaBox.SelectedItem == "Dacia")
                {
                    ModelBox.Items.Add("Duster");
                    ModelBox.Items.Add("Sandero");
                    ModelBox.Items.Add("Jogger");
                    ModelBox.Items.Add("Dokker");
                    ModelBox.Items.Add("Lodgy");
                }

                else if (MarkaBox.SelectedItem == "Citroen")
                {
                    ModelBox.Items.Add("C3");
                    ModelBox.Items.Add("C4");
                    ModelBox.Items.Add("C5");
                    ModelBox.Items.Add("C-Elysee");
                    ModelBox.Items.Add("Berlingo");
                    ModelBox.Items.Add("Picasso");
                }

                else if (MarkaBox.SelectedItem == "Chevrolet")
                {
                    ModelBox.Items.Add("Aveo");
                    ModelBox.Items.Add("Cruze");
                    ModelBox.Items.Add("Captiva");
                    ModelBox.Items.Add("Trax");
                    ModelBox.Items.Add("Camaro");
                }

                else if (MarkaBox.SelectedItem == "BMW")
                {
                    ModelBox.Items.Add("1 Serisi");
                    ModelBox.Items.Add("2 Serisi");
                    ModelBox.Items.Add("3 Serisi");
                    ModelBox.Items.Add("4 Serisi");
                    ModelBox.Items.Add("5 Serisi");
                    ModelBox.Items.Add("X1");
                    ModelBox.Items.Add("X2");
                    ModelBox.Items.Add("X3");
                    ModelBox.Items.Add("iX");
                }

                else if (MarkaBox.SelectedItem == "Audi")
                {
                    ModelBox.Items.Add("A1");
                    ModelBox.Items.Add("A3");
                    ModelBox.Items.Add("S3");
                    ModelBox.Items.Add("A4");
                    ModelBox.Items.Add("RS4");
                    ModelBox.Items.Add("A5");
                    ModelBox.Items.Add("S5");
                    ModelBox.Items.Add("RS5");
                    ModelBox.Items.Add("RS5");
                    ModelBox.Items.Add("A6");
                    ModelBox.Items.Add("RS6");
                    ModelBox.Items.Add("A7");
                    ModelBox.Items.Add("A8");
                }

                else if (MarkaBox.SelectedItem == "Renault")
                {
                    ModelBox.Items.Add("Clio");
                    ModelBox.Items.Add("Taliant");
                    ModelBox.Items.Add("Captur");
                    ModelBox.Items.Add("Megane");
                    ModelBox.Items.Add("Austral");
                    ModelBox.Items.Add("Kaleos");
                    ModelBox.Items.Add("Kadjar");
                    ModelBox.Items.Add("Fluence");
                    ModelBox.Items.Add("Symbol");
                    ModelBox.Items.Add("Talisman");
                }
                else if (MarkaBox.SelectedItem == "Ford")
                {
                    ModelBox.Items.Add("Fiesta");
                    ModelBox.Items.Add("Focus");
                    ModelBox.Items.Add("Puma");
                    ModelBox.Items.Add("Kuga");
                    ModelBox.Items.Add("Transit");
                    ModelBox.Items.Add("Tourneo");
                    ModelBox.Items.Add("Mondeo");
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }

        private void AddCar_Btn_Click(object sender, EventArgs e)
        { //plaka veritabanına kayıtlı mı diye kontrol edebiliriz 
            if (MarkaBox.SelectedItem != null
                && ModelBox.SelectedItem != null
                && CatBox.SelectedItem != null
                && YakitBox.SelectedItem != null
                && VitesBox.SelectedItem != null
                && Plaka_Textbox.Text != null
                && Kilometre_Textbox.Text != null)
            {
                if (Arac.AracClass.AracEkle(MarkaBox.SelectedItem.ToString(), 
                    ModelBox.SelectedItem.ToString(), CatBox.SelectedItem.ToString(), 
                    YakitBox.SelectedItem.ToString(), VitesBox.SelectedItem.ToString(),
                    Plaka_Textbox.Text, Convert.ToInt32(Kilometre_Textbox.Text)))
                {
                    Close();
                }

            }
            else
            {
                HataMesajlari.BosOlamaz();
            }
        }

        private void Plaka_Textbox_TextChanged(object sender, EventArgs e)
        {
            char[] charsToTrim = Form1.instance.charsToTrim;

            Plaka_Textbox.Text = Plaka_Textbox.Text.Trim(charsToTrim);
            Plaka_Textbox.SelectionStart = Plaka_Textbox.Text.Length;
        }
    }
}
