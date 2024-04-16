using AracKiralama.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama.Class
{
    class Musteri
    {

        public static Musteri MusteriClass = new Musteri();
        ArabaKiralamaEntities musteri = new ArabaKiralamaEntities();

        bool IsMusteriReal(string username, string pass)
        {
            try
            {
                if (username == "admin" && pass == "admin")
                {
                    Form1.instance.ShowAdminPanel();
                }
                else
                {

                    try
                    {
                        var user = musteri.Kullanici.FirstOrDefault(x => x.Kullanici_Adi == username);
                        //var password = musteri.Kullanici.FirstOrDefault(x => x.Sifre == pass);

                        if (user.Sifre.Trim() == pass)
                        {
                            return true;
                        }

                        else if (user == null)
                        {
                            HataMesajlari.KullaniciBulunamadi();
                            return false;
                        }
                        else if (user.Sifre.Trim() != pass)
                        {
                            HataMesajlari.Uyumsuz();
                            return false;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch
                    {

                    }
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        public bool GirisYap(string username, string pass)
        {
            if (IsMusteriReal(username, pass))
            {
                Form1.instance.ShowUserPanel();
                return true;
            }
            else
            {
                if (username != "admin" && pass != "admin")
                {
                    HataMesajlari.KullaniciBulunamadi();
                }
                return false;
            }
        }

        public void KayitOl(string username, string pass, string dogumTarihi, string ehliyetTarihi)
        {
            if (!IsMusteriReal(username, pass))
            {
                try
                {
                    Kullanici kullanici = new Kullanici();
                    kullanici.Kullanici_Adi = username;
                    kullanici.Sifre = pass;
                    kullanici.Dogum_Tarihi = Convert.ToDateTime(dogumTarihi);
                    kullanici.Ehliyet_Tarihi = Convert.ToDateTime(ehliyetTarihi);
                    musteri.Kullanici.Add(kullanici);
                    musteri.SaveChanges();
                    BasariliMesajlar.KayitBasarili();
                }
                catch
                {
                    throw new NotImplementedException();
                }

            }
            else
            {
                HataMesajlari.KullaniciVar();
            }

        }

        internal bool KullaniciAdiDegistir(string username, string newUsername)
        {
            try
            {
                var newUser = musteri.Kullanici.FirstOrDefault(x => x.Kullanici_Adi == newUsername);
                if(newUser == null)
                {
                    var user = musteri.Kullanici.FirstOrDefault(x => x.Kullanici_Adi == username);
                    user.Kullanici_Adi = newUsername; 
                    musteri.SaveChanges();
                    return true;
                }
                else
                {
                    HataMesajlari.KullaniciVar();
                }
            }
            catch
            {

            }
            return false;
        }

        internal bool SifreDegistir(string username, string oldPass, string newPass)
        {
            try
            {
                var user = musteri.Kullanici.FirstOrDefault(x => x.Kullanici_Adi == username);
                if(user.Sifre.Trim() == oldPass)
                {
                    user.Sifre = newPass;
                    musteri.SaveChanges();
                    return true;
                }
                else
                {
                    HataMesajlari.EskiSifreYanlis();
                }

            }
            catch
            {

            }
            return false;
        }

        /*internal void AracKirala(int carId, int userId)
        {
            try
            {
                var arac = musteri.Araba.Find(carId);
                var user = musteri.Kullanici.Find(userId);

                Kiralamalar kirala = new Kiralamalar();
                kirala.Kullanici_Id = user.Id;
                kirala.Arac_Id = arac.Id;
                kirala.AktifMi = true;
                kirala.Tarih = DateTime.Now;
                arac.BostaMi = false;
                musteri.Kiralamalar.Add(kirala);
                musteri.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }*/
    }
}
