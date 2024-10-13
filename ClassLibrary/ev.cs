namespace ClassLibrary
{
    public class Ev
    {
        public static List<Ev> evler = new List<Ev>(1000);
        public static int sehir = 0;
        public static int id = 1;

        public string il { get; set; }
        public string ilce { get; set; }
        public decimal EmlakNumarasi { get; set;}
        public decimal Alan { get; set; }
        public string Tip { get; set; }
        public string turu { get; set; }
        public int KatNumarasi { get; set; }
        public int Yasi { get; set; }

        public int OdaSayisi { get; set; }




        public Ev(
                    string il = "Ankara",
                    string ilce = "Keçiören",
                    int KatNumarasi = 0,
                    decimal Alan = 10,
                    int OdaSayisi = 1,
                    string Tip = "Daire",
                    string turu = "satilik",
                    int Yasi = 0

            )
        {
            this.il = il;
            this.ilce = ilce;
            this.Tip = Tip;
            this.turu = turu;
            this.KatNumarasi = KatNumarasi;
            if (Yasi >= 0)
            {
                this.Yasi = Yasi;
            }
            else
            {

                LogKayıt.LogKayit($"Yaşına Gecersiz Giriş Yapıldı: " + Yasi);
                this.Yasi = 1;
            }
            if (Alan >= 0)
            {
                this.Alan = Alan;
            }
            else
            {

                LogKayıt.LogKayit($"Alana Gecersiz Giriş Yapıldı: " + Alan);
                this.Alan = 0;
            }
           
            if (OdaSayisi > 0)
            {
                this.OdaSayisi = OdaSayisi;
            }
            else
            {
                LogKayıt.LogKayit($"Oda Sayısına Gecersiz Giriş Yapıldı: " + OdaSayisi);
                this.OdaSayisi = 1;
            }
            EmlakNumarasi = decimal.Parse(((int.Parse(Ev.sehir.ToString()) * 1000 + Ev.id).ToString()));
        }

        public Ev(
                    string il = "Ankara",
                    string ilce = "Keçiören",
                    int KatNumarasi = 0,
                    decimal Alan = 10,
                    int OdaSayisi = 1,
                    string Tip = "Daire",
                    string turu = "satilik",
                    int Yasi = 0,


                    decimal YapıID = 111111111)
        {
            this.il = il;

            if (OdaSayisi > 0)
            {
                this.OdaSayisi = OdaSayisi;
            }
            else
            {
                LogKayıt.LogKayit($"Oda Sayısına Gecersiz Giriş Yapıldı: " + OdaSayisi);

                this.OdaSayisi = 1;
            }

            if (Alan >= 0)
            {
                this.Alan = Alan;
            }
            else
            {

                LogKayıt.LogKayit($"Alana Gecersiz Giriş Yapıldı: " + Alan);
                this.Alan = 0;
            }

            if (Yasi >= 0)
            {
                this.Yasi = Yasi;
            }
            else
            {

                LogKayıt.LogKayit($"Yaşına Gecersiz Giriş Yapıldı: " + Yasi);
                this.Yasi = 1;
            }
            this.ilce = ilce;
            this.EmlakNumarasi = YapıID;
            this.turu = turu;
            this.Tip=Tip;
            this.KatNumarasi = KatNumarasi;
        }

        virtual public string EvBilgileri()
        {
            
            return string.Format(" ilce : {0} KatNumarasi : {1} Alan : {2} OdaSayisi : {3} Tip : {4} Yasi : {5}",
                ilce,KatNumarasi, Alan,OdaSayisi, Tip,Yasi);
        }
       
    }
    public class SatilikEv : Ev
    {
        public decimal Fiyat;

        public SatilikEv(string il, string ilce,int KatNumarasi, int Alan,int OdaSayisi ,string Tip, string turu,int Yasi, decimal Fiyat = 300000)
            : base(il, ilce,KatNumarasi, Alan,OdaSayisi,Tip, turu,Yasi)
        {
            this.Fiyat = Math.Max(Fiyat, 0);
        }

        public SatilikEv(string il, string ilce, int KatNumarasi, int Alan, int OdaSayisi, string Tip, string turu, int Yasi, decimal Fiyat = 300000, decimal YapıID= 111111111)
                        : base(il, ilce, KatNumarasi, Alan, OdaSayisi, Tip, turu, Yasi,YapıID)
        {
            this.Fiyat = Math.Max(Fiyat, 0);
            this.EmlakNumarasi = YapıID;
        }

        public override string EvBilgileri()
        {


            return string.Format(" ilce : {0} KatNumarasi : {1} Alan : {2} OdaSayisi : {3} Tip : {4} Yasi : {5} Fiyat : {6}",
               ilce, KatNumarasi, Alan, OdaSayisi, Tip, Yasi, Fiyat);
          
        }
    }

    public class KiralikEv : Ev
    {
        public decimal Kira,Depozito;

        public KiralikEv(string il, string ilce, int KatNumarasi, int Alan, int OdaSayisi, string Tip, string turu, int Yasi, decimal Kira = 10000,decimal Depozito=1000)
            : base(il, ilce, KatNumarasi, Alan, OdaSayisi, Tip, turu, Yasi)



        {
            this.Kira = Math.Max(Kira, 0);
            this.Depozito = Math.Max(Depozito, 0);



        }


        public KiralikEv(string il, string ilce, int KatNumarasi, int Alan, int OdaSayisi, string Tip, string turu, int Yasi, decimal Kira = 10000, decimal Depozito = 1000, decimal EmlakNumarasi = 111111111)
                        : base(il, ilce, KatNumarasi, Alan, OdaSayisi, Tip, turu, Yasi, EmlakNumarasi)
        {
            this.Kira = Math.Max(Kira, 0);
            this.Depozito = Math.Max(Depozito, 0);

            this.EmlakNumarasi=EmlakNumarasi;
        }

        public override string EvBilgileri()
        {
            return string.Format(" ilce : {0} KatNumarasi : {1} Alan : {2} OdaSayisi : {3} Tip : {4} Yasi : {5} Kira : {6} Depozito {7}",
               ilce, KatNumarasi, Alan, OdaSayisi, Tip, Yasi, Kira, Depozito);
            
        }
    }





}
