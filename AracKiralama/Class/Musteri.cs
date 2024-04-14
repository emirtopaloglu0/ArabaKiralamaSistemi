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
                        var password = musteri.Kullanici.FirstOrDefault(x => x.Sifre == pass);

                        if (user.Id == password.Id)
                        {
                            return true;
                        }

                        else if (user == null)
                        {
                            HataMesajlari.KullaniciBulunamadi();
                            return false;
                        }
                        else if (user.Id != password.Id)
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

        void KullaniciAdiDegistir()
        {

        }


    }
}
