using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace emlak
{
    public partial class Ekleme : Form
    {
        public decimal EmlakNumarasi = 111111111;


        public Ekleme()
        {
            InitializeComponent();
        }


        private void IL_SelectedValueChanged(object sender, EventArgs e)
        {
            Ev.sehir = (IL.SelectedIndex) + 1;
            string dosya_yolu = @"C:\Users\cengi\Desktop\Yeni klasör (3)\emlak\semtler.txt";
            if (!File.Exists(dosya_yolu))
            {
                MessageBox.Show("Semt Dosyası Bulunmuyor");
                return;
            }
            else
            {

                List<string> semtler = D_Islemleri.DosyaOkumaSemt(dosya_yolu, IL.Text);
                ILCE.Items.Clear();
                foreach (string semt in semtler)
                {
                    ILCE.Items.Add(semt);
                }
                ILCE.Enabled = true;
            }
        }

        public Ekleme(string il, string ilce, int OdaSayisi, int KatNumarasi, decimal Alan, string Tip, string turu,
        int yasi, decimal Fiyat = 800, decimal EmlakNumarasi = 111111111)
        {
            InitializeComponent();
            Oda_Sayisi.Text = OdaSayisi.ToString();
            Kat_Numarasi.Text = KatNumarasi.ToString();
            IL.Text = il.ToString();
            ILCE.Text = ILCE.ToString();
            tAlan.Text = Alan.ToString();
            Ev_Turu.Text = Tip.ToString();
            if (turu.Equals("satilik"))
            {
                Satilik.Checked = true;
            }

            tFiyat.Text = Fiyat.ToString();
            Yapim.Text = yasi.ToString();
            FileStream fs = new FileStream(@"C:\Users\cengi\Desktop\Yeni klasör (3)\emlak\room.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string yazi = sr.ReadLine();
            int i = 0;
            while (yazi != null)
            {
                string[] dosya = yazi.Split('|');

                yazi = sr.ReadLine();
                i++;
            }
            this.EmlakNumarasi = EmlakNumarasi;
            sr.Close();
            fs.Close();
        }

        public Ekleme(string il, string ilce, int OdaSayisi, int KatNumarasi, decimal Alan, string Tip, string turu,
        int yasi, decimal Kira = 800, decimal Depozito = 100, decimal EmlakNumarasi = 111111111)
        {
            InitializeComponent();
            Oda_Sayisi.Text = OdaSayisi.ToString();
            Kat_Numarasi.Text = KatNumarasi.ToString();
            IL.Text = il.ToString();
            ILCE.Text = ILCE.ToString();
            tAlan.Text = Alan.ToString();
            Ev_Turu.Text = Tip.ToString();
            Yapim.Text = yasi.ToString();

        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ILCE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void Ekleme_Load(object sender, EventArgs e)
        {

        }
        private void Oda_Sayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Kat_Numarasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Kat_Numarası_TextChanged(object sender, EventArgs e)
        {

        }

        private void Satilik_CheckedChanged(object sender, EventArgs e)
        {
            kontrol.SatilikRadioButton(this);


        }
        private void Kiralik_CheckedChanged(object sender, EventArgs e)
        {
            kontrol.KiralikRadioButton(this);
        }
        private void Kaydet_Click(object sender, EventArgs e)
        {
            bool Kontrol = kontrol.FormButtonKontrol(this);
            if (Kontrol)
            {
                int i = 0;
                foreach (Ev ev in Ev.evler)
                {
                    Console.WriteLine(ev.EmlakNumarasi);
                    Console.WriteLine(ev.OdaSayisi);

                }
                foreach (Ev ev in Ev.evler)
                {
                    if (ev.EmlakNumarasi == EmlakNumarasi)
                    {
                        Ev.evler.RemoveAt(i);
                        break;
                    }
                    i++;
                }

                if (Satilik.Checked)
                {

                    SatilikEv satilikEv = new SatilikEv(
                        IL.Text, ILCE.Text, int.Parse(Kat_Numarasi.Text), int.Parse(tAlan.Text), int.Parse(Oda_Sayisi.Text), Ev_Turu.Text, "satilik",
                        int.Parse(Yapim.Text), int.Parse(tFiyat.Text));
                    Ev.evler.Add(satilikEv);
                    MessageBox.Show("Satılık Ev Kayıt Edildi");
                    string dosya_yolu = @"C:\Users\cengi\Desktop\Yeni klasör (3)\emlak\satilik.txt";
                    D_Islemleri.DosyaSatilikYazmak(dosya_yolu, "satilik");
                    this.Close();
                }

                else
                {

                    KiralikEv kiralikEv = new KiralikEv(IL.Text,
                        ILCE.Text, int.Parse(Kat_Numarasi.Text), int.Parse(tAlan.Text), int.Parse(Oda_Sayisi.Text), Ev_Turu.Text, "kiralik", int.Parse(Yapim.Text), decimal.Parse(Kira.Text), decimal.Parse(tDepozito.Text));
                    Ev.evler.Add(kiralikEv);
                    MessageBox.Show("Kiralık Ev Kayıt Edildi");
                    string dosya_yolu = @"C:\Users\cengi\Desktop\Yeni klasör (3)\emlak\kiralik.txt";

                    D_Islemleri.DosyaKiralikEvYazmak(dosya_yolu, "kiralik");
                }
                Ev.id++;
                İşlemler islemler = new İşlemler();
                islemler.Show();
                this.Hide();
                islemler.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Boş yerleri doldurunuz");

            }


        }

        private void Ev_Turu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Geri_Click(object sender, EventArgs e)
        {
            İşlemler islemler = new İşlemler();
            islemler.Show();
            this.Hide();
            islemler.FormClosed += (s, args) => this.Close();
        }

        private void Yapim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
