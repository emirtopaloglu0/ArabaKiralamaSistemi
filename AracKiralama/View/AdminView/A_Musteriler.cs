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
    public partial class A_Musteriler : UserControl
    {
        //Kullanici kullanici = new Kullanici();
        ArabaKiralamaEntities db = new ArabaKiralamaEntities();
        int userId;
        //public static A_Musteriler instance;
        public A_Musteriler()
        {
            InitializeComponent();
        }

        public Timer timer1 = new Timer();

        private void A_Musteriler_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Tick += Timer_Tick;
            timer1.Start();
            panel1.Hide();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                var kullanici = db.Kullanici.ToList();
                CustomersDataGrid.DataSource = kullanici;
            }
            catch
            {

            }

        }

        private void ActiveRentals_Btn_Click(object sender, EventArgs e)
        {
            List<Kiralamalar> rentals = db.Kiralamalar.Where(x => x.AktifMi == true).ToList();
            RentalsDataGrid.DataSource = rentals;
            MarkaTextBox.Text = null;
            ModelTextBox.Text = null;
            YakitTextBox.Text = null;
            KmTextBox.Text = null;
            panel1.Show();

        }

        private void CancelledRentals_Btn_Click(object sender, EventArgs e)
        {
            List<Kiralamalar> rentals = db.Kiralamalar.Where(x => x.IptalMi == true || x.AktifMi == false).ToList();
            RentalsDataGrid.DataSource = rentals;
            RentalsDataGrid.DataSource = rentals;
            MarkaTextBox.Text = null;
            ModelTextBox.Text = null;
            YakitTextBox.Text = null;
            KmTextBox.Text = null;
            panel1.Show();
        }

        private void CustomersDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                userId = Convert.ToInt32(CustomersDataGrid.SelectedCells[0].Value);
                Username_Textbox.Text = CustomersDataGrid.SelectedCells[1].Value.ToString();
                DOB_Textbox.Text = CustomersDataGrid.SelectedCells[2].Value.ToString();
                Licance_Textbox.Text = CustomersDataGrid.SelectedCells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void RentalsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var car = db.Araba.Find(RentalsDataGrid.SelectedCells[1].Value);
                MarkaTextBox.Text = car.Marka;
                ModelTextBox.Text = car.Model;
                YakitTextBox.Text = car.Yakit_Turu;
                KmTextBox.Text = car.Kilometre.ToString();
            }
            catch
            {

            }
        }
    }
}
