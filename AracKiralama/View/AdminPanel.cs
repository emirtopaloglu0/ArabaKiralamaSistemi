using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama.View
{
    public partial class AdminPanel : UserControl
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            a_Araclar1.Hide();
        }


        private void Cars_Btn_Click(object sender, EventArgs e)
        {
            a_Araclar1.Show();
            a_Musteriler1.Hide();
            a_Musteriler1.timer1.Stop();
            a_Araclar1.timer2.Start();
        }

        private void Customers_Btn_Click(object sender, EventArgs e)
        {
            a_Araclar1.Hide();
            a_Musteriler1.Show();
            a_Musteriler1.timer1.Start();
            a_Araclar1.timer2.Stop();
        }
    }
}
