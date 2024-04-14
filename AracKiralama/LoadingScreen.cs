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
    public partial class LoadingScreen : Form
    {
        Timer timer = new Timer();

        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        int sayi;
        private void Timer_Tick(object sender, EventArgs e)
        {
            sayi += 10;
            if(sayi >= 30)
            {
               
                timer.Stop();
                
                Form1.instance.ShowForm();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                this.Close();

            }
        }
    }
}
