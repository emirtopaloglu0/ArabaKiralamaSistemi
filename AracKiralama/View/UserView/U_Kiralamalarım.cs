using AracKiralama.Class;
using AracKiralama.Model;
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
    public partial class U_Kiralamalarım : UserControl
    {
        public Timer timer4 = new Timer();
        ArabaKiralamaEntities db = new ArabaKiralamaEntities();

        public U_Kiralamalarım()
        {
            InitializeComponent();
            timer4.Interval = 1000;
            timer4.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            List<Kiralamalar> kiralamalar = db.Kiralamalar.Where(x => x.Kullanici_Id == UserPanel.instance.userId).ToList();
            RentalsDataGrid.DataSource = kiralamalar;
            RentalsDataGrid.ClearSelection();
        }

        public int k_CarId, k_Km, k_Id;

        private void CancelRental_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogMesjalar.instance.CancelRent();
                if (DialogMesjalar.instance.res == DialogResult.Yes)
                {
                    var araba = db.Araba.Find(k_CarId);
                    var kira = db.Kiralamalar.Find(Int32.Parse(Id_TextBox.Text));
                    if (kira.AktifMi == true)
                    {
                        var kiralama = db.Kiralamalar.Find(Int32.Parse(Id_TextBox.Text));
                        kiralama.AktifMi = false;
                        kiralama.IptalMi = true;
                        araba.BostaMi = true;
                        db.SaveChanges();
                    }
                    else
                    {
                        HataMesajlari.AktifSecim();
                    }
                    
                }

            }
            catch
            {

            }


        }

        public string k_Marka, k_Model, k_Kategori, k_Yakit, k_Vites, k_Plaka;
        private void RentalsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                k_Id = Convert.ToInt32(RentalsDataGrid.SelectedCells[0].Value);
                k_CarId = Convert.ToInt32(RentalsDataGrid.SelectedCells[1].Value);
                var car = db.Araba.Find(k_CarId);
                k_Marka = car.Marka;
                k_Model = car.Model;
                k_Kategori = car.Kategori;
                k_Yakit = car.Yakit_Turu;
                k_Vites = car.Vites_Turu;
                k_Plaka = car.Plaka;
                k_Km = car.Kilometre;

                Marka_Textbox.Text = k_Marka.Trim();
                Model_Textbox.Text = k_Model.Trim();
                Kategori_Textbox.Text = k_Kategori.Trim();
                Yakit_Textbox.Text = k_Yakit.Trim();
                Vites_Textbox.Text = k_Vites.Trim();
                Plaka_Textbox.Text = k_Plaka.Trim();
                Kilometre_Textbox.Text = k_Km.ToString().Trim();
                Id_TextBox.Text = k_Id.ToString().Trim();
                if (k_Kategori.Trim() == "A")
                {
                    FiyatTextBox.Text = "50₺";
                }
                else if (k_Kategori.Trim() == "B")
                {
                    FiyatTextBox.Text = "30₺";
                }
                else
                {
                    FiyatTextBox.Text = "20₺";
                }
            }
            catch
            {

            }
        }
    }
}
