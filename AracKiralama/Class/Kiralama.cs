using AracKiralama.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Class
{
    internal class Kiralama
    {
        public static Kiralama kiralamaClass = new Kiralama();
        ArabaKiralamaEntities kiralama = new ArabaKiralamaEntities();

        internal bool AracKirala(int carId, int userId)
        {

            try
            {
                var arac = kiralama.Araba.Find(carId);
                var user = kiralama.Kullanici.Find(userId);

                Kiralamalar kirala = new Kiralamalar();
                kirala.Kullanici_Id = user.Id;
                kirala.Arac_Id = arac.Id;
                kirala.AktifMi = true;
                kirala.Tarih = DateTime.Now;
                arac.BostaMi = false;
                kiralama.Kiralamalar.Add(kirala);
                kiralama.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return false;


        }

        internal bool KiralaIptal(int carId, int kiraId)
        {

            try
            {
                var kira = kiralama.Kiralamalar.Find(kiraId);
                if (kira.AktifMi == true)
                {
                    var araba = kiralama.Araba.Find(carId);
                    //var kirala = kiralama.Kiralamalar.Find(Int32.Parse(Id_TextBox.Text));
                    kira.AktifMi = false;
                    //kira.IptalMi = true;
                    araba.BostaMi = true;
                    kiralama.SaveChanges();
                    return true;
                }

                else
                {
                    HataMesajlari.AktifSecim();
                }
            }
            catch
            {

            }


            return false;
        }


    }
}
