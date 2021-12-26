using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjeDonem1_DOTNET_
{
    class Sistem
    {   
        public static Form1 frm1;
        public static Musteri m1;
        public static frmSipraisAnaEkran frmSiparis;
        public static frmMusteriGirisEkrani frmMusGiris;
        public static frmMusteriKayitEkrani frmMusKayit;
        public static frmOdemeEkrani frmOdEkran;
        public static frmKullaniciBilgileri frmKulBil;
        public static frmAdresEkle frmAdEkle;
        public static frmCalisanAnaEkrani frmCalEk;
        public static string KulAd, KulSifre;
        public static frmKapidaOdeme frmKapOd;
        public static frmOdemeYontemi frmOdYon;
        public static frmCalisanSecim frmCalSec;
        public static frmMusteriTakip frmMusTak;
        public static frmSiparislerim frmSip;
        public static frmCalisanGirisEkrani frmCalGir;
        public static string sqlbag = "Data Source=DESKTOP-UJGISA7;Initial Catalog='Proje Donem1';Integrated Security=True";
        
    }
}
