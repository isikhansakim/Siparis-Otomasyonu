using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDonem1_DOTNET_
{
    class Musteri
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public List<Adres> Adres { get; set; }

        public List<Urun> Sepet;

        public List<KrediKarti> KrediKartlari;

        public Musteri(string KullaniciAdi, string Sifre, string Ad, string Soyad)
        {
            this.KullaniciAdi = KullaniciAdi;
            this.Sifre = Sifre;
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.Sepet = new List<Urun>();
            this.KrediKartlari = new List<KrediKarti>();
            this.Adres = new List<Adres>();

        }
    }
}
