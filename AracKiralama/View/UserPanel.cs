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

namespace AracKiralama.View
{
    public partial class UserPanel : UserControl
    {

        public static UserPanel instance;
        public string loggedUser;
        ArabaKiralamaEntities db = new ArabaKiralamaEntities();
        public int userId;

        public UserPanel()
        {
            InitializeComponent();
            instance  = this;
        }

        internal void LoggedIn()
        {
            userLabel.Text = loggedUser;
            try
            {
                var user = db.Kullanici.FirstOrDefault(x => x.Kullanici_Adi == loggedUser);
                userId = user.Id;
            }
            catch
            {

            }
        }

        private void logOut_Btn(object sender, EventArgs e)
        {
            DialogMesjalar.instance.LogoutUserPanel();
            if(DialogMesjalar.instance.res == DialogResult.Yes)
            {
                Form1.instance.ShowLoginPanel();
            }
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            u_AracKirala1.Hide();
            u_Ayarlar1.Hide();
            u_Kiralamalarım1.timer4.Start();
        }

        private void MyRentals_Btn_Click(object sender, EventArgs e)
        {
            u_AracKirala1.timer3.Stop();
            u_Kiralamalarım1.timer4.Start();
            u_Ayarlar1.Hide();
            u_Kiralamalarım1.Show();
            u_AracKirala1.Hide();
        }

        private void Settings_Btn_Click(object sender, EventArgs e)
        {
            u_AracKirala1.timer3.Stop();
            u_Kiralamalarım1.timer4.Stop();
            u_Ayarlar1.Show();
            u_Kiralamalarım1.Hide();
            u_AracKirala1.Hide();
        }

        private void RentCar_Btn_Click(object sender, EventArgs e)
        {
            u_AracKirala1.timer3.Start();
            u_Kiralamalarım1.timer4.Stop();
            u_Ayarlar1.Hide();
            u_Kiralamalarım1.Hide();
            u_AracKirala1.Show();
        }
    }
}
