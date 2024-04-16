using AracKiralama.Class;
using AracKiralama.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AracKiralama.View.UserView
{
    public partial class U_AracKirala : UserControl
    {
        public Timer timer3 = new Timer();
        ArabaKiralamaEntities db = new ArabaKiralamaEntities();
        public static U_AracKirala instance;
        public U_AracKirala()
        {
            InitializeComponent();
            timer3.Interval = 1000;
            timer3.Tick += Timer_Tick;
            instance = this;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            List<Araba> araclar = db.Araba.Where(x => x.SilindiMi == false && x.BostaMi == true).ToList();
            KiralamaDataGrid.DataSource = araclar;
            KiralamaDataGrid.ClearSelection();
        }
        public int kira_CarId, kira_Km;
        public string kira_Marka, kira_Model, kira_Kategori, kira_Yakit, kira_Vites, kira_Plaka;

        private void RentCar_Btn_Click(object sender, EventArgs e)
        {
            if (Marka_Textbox.Text != null && Model_Textbox.Text != null
                && Kategori_Textbox.Text != null && Yakit_Textbox.Text != null
                && Vites_Textbox.Text != null && Plaka_Textbox.Text != null
                && Kilometre_Textbox.Text != null && Id_TextBox.Text != null)
            {
                DialogMesjalar.instance.Rent();
                if (DialogMesjalar.instance.res == DialogResult.Yes)
                {
                    try
                    {
                        var user = db.Kullanici.FirstOrDefault(x => x.Kullanici_Adi == UserPanel.instance.loggedUser);

                        if(Kiralama.kiralamaClass.AracKirala(Convert.ToInt32(Id_TextBox.Text), user.Id))
                        {
                            BasariliMesajlar.KiralamaBasarili();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                }
            }
            else
            {
                HataMesajlari.BosOlamaz();
            }

        }

        private void KiralamaDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                kira_CarId = Convert.ToInt32(KiralamaDataGrid.SelectedCells[0].Value);
                kira_Marka = KiralamaDataGrid.SelectedCells[1].Value.ToString();
                kira_Model = KiralamaDataGrid.SelectedCells[2].Value.ToString();
                kira_Kategori = KiralamaDataGrid.SelectedCells[3].Value.ToString();
                kira_Yakit = KiralamaDataGrid.SelectedCells[4].Value.ToString();
                kira_Vites = KiralamaDataGrid.SelectedCells[5].Value.ToString();
                kira_Plaka = KiralamaDataGrid.SelectedCells[6].Value.ToString();
                kira_Km = Convert.ToInt32(KiralamaDataGrid.SelectedCells[7].Value);

                Marka_Textbox.Text = kira_Marka.Trim();
                Model_Textbox.Text = kira_Model.Trim();
                Kategori_Textbox.Text = kira_Kategori.Trim();
                Yakit_Textbox.Text = kira_Yakit.Trim();
                Vites_Textbox.Text = kira_Vites.Trim();
                Plaka_Textbox.Text = kira_Plaka.Trim();
                Kilometre_Textbox.Text = kira_Km.ToString().Trim();
                Id_TextBox.Text = kira_CarId.ToString().Trim();
                if (kira_Kategori.Trim() == "A")
                {
                    FiyatTextBox.Text = "50₺";
                }
                else if (kira_Kategori.Trim() == "B")
                {
                    FiyatTextBox.Text = "30₺";
                }
                else
                {
                    FiyatTextBox.Text = "20₺";
                }
            }
            catch
            {

            }

        }
    }
}
