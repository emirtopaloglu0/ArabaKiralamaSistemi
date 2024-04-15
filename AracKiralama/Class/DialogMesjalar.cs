using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama.Class
{
    internal class DialogMesjalar
    {
        public static DialogMesjalar instance = new DialogMesjalar();
        
        public DialogResult res;

        public void RegisterExit()
        {
            res = MessageBox.Show("İptal Etmek İstediğinze Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public void CloseApp()
        {
            res = MessageBox.Show("Çıkmak İstediğinze Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public void LogoutUserPanel()
        {
            res = MessageBox.Show("Ana Sayfaya Dönmek İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal void UpdateCar()
        {
            res = MessageBox.Show("Güncellemek İstediğinze Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal void RemoveCar()
        {
            res = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal void Rent()
        {
            res = MessageBox.Show("Bu Aracı Kiralamak İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal void CancelRent()
        {
            res = MessageBox.Show("Bu Kiralamayı İptal Etmek İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
    }
}
