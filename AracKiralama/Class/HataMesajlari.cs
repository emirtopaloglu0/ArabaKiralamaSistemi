using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama.Class
{
    internal class HataMesajlari
    {

        public static void KullaniciBulunamadi()
        {
            MessageBox.Show("Böyle bir kullanıcı bulunamadı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Uyumsuz()
        {
            MessageBox.Show("Girdiğiniz şifre ile kullanıcı adı uyuşmamaktadır!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void KullaniciVar()
        {
            MessageBox.Show("Girdiğiniz kullanıcı adı kullanılmaktadır. Lütfen başka bir ad seçiniz", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void YasYetersiz()
        {
            MessageBox.Show("Yaşınız araç kiralamaya uygun değildir!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void EhliyetYiliYetersiz()
        {
            MessageBox.Show("Ehliyetinizi aldığınız tarih üzerinden en az 1 yıl geçmesi gerekir!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void BosOlamaz()
        {
            MessageBox.Show("Boş alan bırakmayınız!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void AdminKayitHata()
        {
            MessageBox.Show("Kullanici adi veya şifreniz 'admin' olamaz!", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void SecimHatasi()
        {
            MessageBox.Show("Lütfen seçim yapınız!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
