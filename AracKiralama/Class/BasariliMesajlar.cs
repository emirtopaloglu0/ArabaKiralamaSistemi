using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama.Class
{
    internal class BasariliMesajlar
    {
        public static void KayitBasarili()
        {
            MessageBox.Show("Kayıt işlemi başarıyla tamamlanmıştır", "Bilgi!", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void GuncellemeBasarili()
        {
            MessageBox.Show("Güncelleme işlemi başarıyla tamamlanmıştır." +
                "\nDeğişiklikleri görmek için uygulamayı kapatıp açmanız gerekiyor!",
                "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        internal static void SilmeBasarili()
        {
            MessageBox.Show("Silme işlemi başarıyla tamamlanmıştır.",
                "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
