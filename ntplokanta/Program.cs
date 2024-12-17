using System;

namespace Lokanta
{
    public class Menu
    {
        public string Isim { get; set; }
        public string Cesit { get; set; }
        public decimal Fiyat { get; set; }
        public string Aciklama { get; set; }

        public Menu(string isim, string cesit, decimal fiyat, string aciklama)
        {
            Isim = isim;
            Cesit = cesit;
            Fiyat = fiyat;
            Aciklama = aciklama;
        }

        public virtual void BilgiYazdir()
        {
            Console.WriteLine($"İsim: " + Isim);
            Console.WriteLine("Çeşit: " + Cesit);
            Console.WriteLine("Fiyat: TL " + Fiyat);
            Console.WriteLine("Açıklama: " + Aciklama);
        }
    }

    public class Yemek : Menu
    {
        public string Porsiyon { get; set; }
        public bool Vegan { get; set; }

        public Yemek(string isim, string cesit, decimal fiyat, string aciklama, string porsiyon, bool vegan)
         : base(isim, cesit, fiyat, aciklama)

        {
            Porsiyon = porsiyon;
            Vegan = vegan;
        }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();
            Console.WriteLine("Porsiyon: " + Porsiyon);
            Console.WriteLine("Vegan: " + Vegan);
        }
    }

    public class Kahvalti : Menu
    {
        public bool SicakIcecekDahil { get; set; }
        public bool AcikBufe { get; set; }

        public Kahvalti(string isim, string cesit, decimal fiyat, string aciklama, bool sicakIcecekDahil, bool acikBufe)
         : base(isim, cesit, fiyat, aciklama)

        {
            SicakIcecekDahil = sicakIcecekDahil;
            AcikBufe = acikBufe;
        }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();
            Console.WriteLine("Sıcak İçecek Dahil: " + SicakIcecekDahil);
            Console.WriteLine("Açık Büfe: " + AcikBufe);
        }
    }
    public class Tatli : Menu
    {
        public bool Glutensiz { get; set; }
        public int Kalori { get; set; }

        public Tatli(string isim, string cesit, decimal fiyat, string aciklama, bool glutensiz, int kalori)
        : base(isim, cesit, fiyat, aciklama)

        {
            Glutensiz = glutensiz;
            Kalori = kalori;
        }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();
            Console.WriteLine("Glutensiz: " + Glutensiz);
            Console.WriteLine("Kalori: kcal " + Kalori);
        }
    }

    public class Icecek : Menu
    {
        public bool Alkollu { get; set; }
        public string Boyut { get; set; }

        public Icecek(string isim, string cesit, decimal fiyat, string aciklama, bool alkollu, string boyut)
          : base(isim, cesit, fiyat, aciklama)
        {
            Alkollu = alkollu;
            Boyut = boyut;
        }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();
            Console.WriteLine("Alkollü: " + Alkollu);
            Console.WriteLine("Boyut: " + Boyut);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Yemek yemek = new Yemek("cağ kebabı", "Ana Yemek", 45.00m, "Baharatlı ve közlenmiş sebzelerle servis edilir.", "Tam Porsiyon", false);

            Kahvalti kahvalti = new Kahvalti("van  Kahvaltısı", "Kahvaltı", 65.00m, "Çeşitli peynirler, zeytinler, kavurmalı yumurta, reçeller ve semaverde çay.", true, true);

            Tatli tatli = new Tatli("Güveç Baklava", "Tatlı", 30.00m, "Cevizli ve şerbetli  tatlı.", false, 300);

            Icecek icecek = new Icecek("Ayran", "İçecek", 12.00m, "Yoğurt ve su karışımı ferahlatıcı içecek.", false, "Orta Boy");

            yemek.BilgiYazdir();
            kahvalti.BilgiYazdir();
            tatli.BilgiYazdir();
            icecek.BilgiYazdir();
        }
    }
}