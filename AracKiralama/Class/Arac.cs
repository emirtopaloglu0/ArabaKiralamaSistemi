using AracKiralama.Model;
using AracKiralama.View.AdminView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Class
{
    internal class Arac
    {
        public static Arac AracClass = new Arac();
        ArabaKiralamaEntities araba = new ArabaKiralamaEntities();


        public bool DurumGuncelle(int id, string marka, string model, string kategori, string yakit, string vites,
            string plaka, int kilometre, string aracDurum)
        {
            try
            {
                var car = araba.Araba.Find(id);
                car.Marka = marka;
                car.Model = model;
                car.Kategori = kategori;
                car.Yakit_Turu = yakit;
                car.Vites_Turu = vites;
                car.Plaka = plaka;
                car.Kilometre = kilometre;
                if(aracDurum == "Boşta")
                {
                    car.BostaMi = true;
                    if (!A_Araclar.instance.aracDurumu)
                    {
                        var kirala = araba.Kiralamalar.FirstOrDefault(x => x.Arac_Id == car.Id && x.AktifMi == true);
                        kirala.IptalMi = true;
                        kirala.AktifMi = false;
                    }
                }
                else if (aracDurum == "Dolu")
                {
                    car.BostaMi = false;
                }
                araba.SaveChanges();
                BasariliMesajlar.GuncellemeBasarili();
                
                return true;
            }
            catch (Exception e)
            {

            }

            return false;
        }

        public bool AracEkle(string marka, string model, string kategori, string yakit, string vites,
            string plaka, int kilometre)
        {
            try
            {
                Araba arac = new Araba();
                arac.Marka = marka;
                arac.Model = model;
                arac.Kategori = kategori;
                arac.Yakit_Turu = yakit;
                arac.Vites_Turu = vites;
                arac.Plaka = plaka;
                arac.Kilometre = kilometre;
                arac.BostaMi = true;
                arac.SilindiMi = false;
                araba.Araba.Add(arac);
                araba.SaveChanges();
                BasariliMesajlar.KayitBasarili();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        internal bool AracSil(int id)
        {
            try
            {
                var arac = araba.Araba.Find(id);
                arac.SilindiMi = true;
                
                var kiralama = araba.Kiralamalar.FirstOrDefault(x => x.Arac_Id == arac.Id);
                if (kiralama.AktifMi)
                {
                    kiralama.AktifMi = false;
                }




                araba.SaveChanges();
                BasariliMesajlar.SilmeBasarili();
                return true;
            }
            catch
            {

            }
            return false;
        }
    }
}
