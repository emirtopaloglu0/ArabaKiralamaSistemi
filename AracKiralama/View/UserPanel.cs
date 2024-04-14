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

namespace AracKiralama.View
{
    public partial class UserPanel : UserControl
    {

        public static UserPanel instance;
        public string loggedUser;

        public UserPanel()
        {
            InitializeComponent();
            instance  = this;
        }

        internal void LoggedIn()
        {
            userLabel.Text = loggedUser;
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
        }
    }
}
