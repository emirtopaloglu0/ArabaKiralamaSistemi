using AracKiralama.Class;
using AracKiralama.Model;
using AracKiralama.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class Form1 : Form
    {

        public static Form1 instance;
        public static ArabaKiralamaEntities db;
        public char[] charsToTrim = { '*', ' ', '\'', '_', '-', '+', '$', '!', '^', '#', '%', '&', '/', '?', '(', ')', '=' };


        public Form1()
        {
            InitializeComponent();
           
            Timer zaman = new Timer();
            zaman.Interval = 1000;
            zaman.Tick += Zaman_Tick;
            zaman.Start();
            instance = this;

        }

        private void Zaman_Tick(object sender, EventArgs e)
        {
            Zaman_Label.Text = DateTime.Now.ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogMesjalar.instance.CloseApp();
            //DialogResult res = MessageBox.Show("Çıkmak İstediğinze Emin Misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogMesjalar.instance.res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            LoadingScreen loadingScreen = new LoadingScreen();
            loadingScreen.Show();
            
            Zaman_Label.Text = DateTime.Now.ToString();
            userPanel2.Visible = false;
            adminPanel2.Visible = false;
            IsAdminVisible();
            
            
        }

        private void IsAdminVisible()
        {
            if (adminPanel2.Visible)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                this.BrandName_Label.ForeColor = SystemColors.ControlLightLight;
                this.Zaman_Label.ForeColor = SystemColors.ControlLightLight;


            }
            else
            {
                this.BackColor = SystemColors.Control;
                this.BrandName_Label.ForeColor = SystemColors.ControlText;
                this.Zaman_Label.ForeColor = SystemColors.ControlText;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        public void ShowAdminPanel()
        {
            adminPanel2.Visible= true;
            loginPanel2.Visible = false;
            userPanel2.Visible = false;
            IsAdminVisible();
            
        }
        public void ShowLoginPanel()
        {
            adminPanel2.Visible = false;
            loginPanel2.Visible = true;
            userPanel2.Visible = false;
            IsAdminVisible();
        }
        public void ShowUserPanel()
        {
            adminPanel2.Visible = false;
            loginPanel2.Visible = false;
            userPanel2.Visible = true;
            IsAdminVisible();
        }

        internal void ShowForm()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.Opacity = 100;
        }
    }
}
