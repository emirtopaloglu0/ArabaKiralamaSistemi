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
            List<Kiralamalar> rentals = db.Kiralamalar.Where(x=> x.AktifMi == true).ToList();
            RentalsDataGrid.DataSource = rentals;
            panel1.Show();
            
        }

        private void CancelledRentals_Btn_Click(object sender, EventArgs e)
        {
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
    }
}
