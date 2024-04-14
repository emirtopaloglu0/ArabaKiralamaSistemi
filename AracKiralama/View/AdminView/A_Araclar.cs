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

namespace AracKiralama.View.AdminView
{
    public partial class A_Araclar : UserControl
    {
        public Timer timer2 = new Timer();
        ArabaKiralamaEntities db = new ArabaKiralamaEntities();
        public static A_Araclar instance;

        public A_Araclar()
        {
            InitializeComponent();
            timer2.Interval = 1000;
            timer2.Tick += Timer_Tick;
            instance = this;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                List<Araba> araclar = db.Araba.Where(x => x.SilindiMi == false).ToList();
                //var araclar = db.Araba.ToList();
                ArabalarDataGrid.DataSource = araclar;
                ArabalarDataGrid.ClearSelection();
            }
            catch
            {

            }


        }

        private void AddCar_Btn_Click(object sender, EventArgs e)
        {
            AracEkle arac = new AracEkle();
            arac.ShowDialog();
        }
        public int carId, km;
        public string marka, model, kategori, yakit_turu, vites_turu, plaka;

        private void button2_Click(object sender, EventArgs e)
        {
            if (Id_TextBox.Text != null)
            {
                DialogMesjalar.instance.RemoveCar();
                if (DialogMesjalar.instance.res == DialogResult.Yes)
                {
                    if (Arac.AracClass.AracSil(Convert.ToInt32(Id_TextBox.Text)))
                    {
                        Marka_Textbox.Text = null;
                        Model_Textbox.Text = null;
                        Kategori_Textbox.Text = null;
                        Yakit_Textbox.Text = null;
                        Vites_Textbox.Text = null;
                        Plaka_Textbox.Text = null;
                        Kilometre_Textbox.Text = null;
                        Id_TextBox.Text = null;
                    }
                }
            }
            else
            {

            }


        }

        // DataGridViewRow selectedRow;
        //DataGridViewCell selectedCell;


        private void button1_Click(object sender, EventArgs e)
        {
            if (Id_TextBox.Text != null)
            {
                AracGuncelleme aracGuncelleme = new AracGuncelleme();
                aracGuncelleme.ShowDialog();
            }
            else
            {
                HataMesajlari.SecimHatasi();
            }

        }

        private void ArabalarDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //selectedRow = ArabalarDataGrid.CurrentRow;
                //selectedCell = ArabalarDataGrid.CurrentCell;

                carId = Convert.ToInt32(ArabalarDataGrid.SelectedCells[0].Value);
                marka = ArabalarDataGrid.SelectedCells[1].Value.ToString();
                model = ArabalarDataGrid.SelectedCells[2].Value.ToString();
                kategori = ArabalarDataGrid.SelectedCells[3].Value.ToString();
                yakit_turu = ArabalarDataGrid.SelectedCells[4].Value.ToString();
                vites_turu = ArabalarDataGrid.SelectedCells[5].Value.ToString();
                plaka = ArabalarDataGrid.SelectedCells[6].Value.ToString();
                km = Convert.ToInt32(ArabalarDataGrid.SelectedCells[7].Value);

                Marka_Textbox.Text = marka;
                Model_Textbox.Text = model;
                Kategori_Textbox.Text = kategori;
                Yakit_Textbox.Text = yakit_turu;
                Vites_Textbox.Text = vites_turu;
                Plaka_Textbox.Text = plaka;
                Kilometre_Textbox.Text = km.ToString();
                Id_TextBox.Text = carId.ToString();

            }
            catch
            {

            }
        }
    }
}
