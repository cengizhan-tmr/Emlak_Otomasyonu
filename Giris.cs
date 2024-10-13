﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace emlak
{
    public partial class Giris : Form
    {

        public Giris()
        {
            InitializeComponent();
        }

        private void Sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void giris_button_Click(object sender, EventArgs e)
        {
            string dosya_yolu = @"C:\Users\cengi\Desktop\Emlak_App\emlak\kullanicilar.txt";
            if (!File.Exists(dosya_yolu))
            {
                MessageBox.Show("Kullanıcı Dosyası Bulunmuyor. Öncelikle Kullanıcı Ekleyiniz");
            }
            else
            {
                List<Kullanici> kullanicilar = D_Islemleri.DosyaOkuma(dosya_yolu);
                string kullaniciAdi = Kullanici_Adi.Text;
                string sifre = Sifre.Text;
                bool girisBasarili = false;

                foreach (Kullanici kullanici in kullanicilar)
                {
                    if (kullanici.Kullanici_Adi.Equals(kullaniciAdi) && kullanici.Sifre.Equals(sifre))
                    {
                        girisBasarili = true;
                        break;
                    }
                }

                if (girisBasarili)
                {
                    MessageBox.Show("Giriş Başarılı");
                    İşlemler İşlemler = new İşlemler();
                    İşlemler.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre Girdiniz");
                }
            }
        }

        private void yeni_kayit_Click(object sender, EventArgs e)
        {
            string dosya_yolu = @"C:\Users\cengi\Desktop\Emlak_App\emlak\kullanicilar.txt";

            if (!File.Exists(dosya_yolu))
            {
                MessageBox.Show("Kullanıcı Dosyası Bulunmuyor. Öncelikle Kullanıcı Ekleyiniz");
                return;
            }
            string kullaniciAdi = Kullanici_Adi.Text;
            string sifre = Sifre.Text;

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre alanları boş olamaz.");
                return;
            }

            List<Kullanici> kullanicilar = D_Islemleri.DosyaOkuma(dosya_yolu);

            foreach (Kullanici kullanici in kullanicilar)
            {
                if (kullanici.Kullanici_Adi.Equals(kullaniciAdi, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Bu kullanıcı adı zaten mevcut. Lütfen başka bir kullanıcı adı seçin.");
                    return;
                }
            }

            kullanicilar.Add(new Kullanici(kullaniciAdi, sifre));

            D_Islemleri.DosyaYazma(dosya_yolu, kullanicilar);

            MessageBox.Show("Yeni kullanıcı başarıyla kaydedildi.");
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}

