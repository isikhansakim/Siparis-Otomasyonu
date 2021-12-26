using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjeDonem1_DOTNET_
{
    public partial class frmMusteriKayitEkrani : Form
    {
        public frmMusteriKayitEkrani()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(Sistem.sqlbag);


        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into tbl_Musteriler (KullaniciAdi,Sifre,Ad,Soyad) values (@a1,@a2,@a3,@a4)", baglanti);
            komut.Parameters.AddWithValue("@a1", txtMusteriKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@a2", txtMusteriSifre.Text);
            komut.Parameters.AddWithValue("@a3", txtMusteriAd.Text);
            komut.Parameters.AddWithValue("@a4", txtMusteriSoyad.Text);
            komut.ExecuteNonQuery();

            SqlCommand komut1 = new SqlCommand("insert into tbl_Adresler(SokakNo, ApartmanNo, DaireNo, Il, Ilce, Musteri_KullaniciAdi) values(@b1, @b2, @b3, @b4, @b5, @b6)", baglanti);
            komut1.Parameters.AddWithValue("@b1", txtSokakNo.Text);
            komut1.Parameters.AddWithValue("@b2", txtAptNo.Text);
            komut1.Parameters.AddWithValue("@b3", txtDaireNo.Text);
            komut1.Parameters.AddWithValue("@b4", txtIl.Text);
            komut1.Parameters.AddWithValue("@b5", txtIlce.Text);
            komut1.Parameters.AddWithValue("@b6", txtMusteriKullaniciAdi.Text);
            komut1.ExecuteNonQuery();

            baglanti.Close();






            if (MessageBox.Show("Girdiğin bilgilerden emin misin?", "Üye Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sistem.m1 = new Musteri(txtMusteriKullaniciAdi.Text, txtMusteriSifre.Text, txtMusteriAd.Text, txtMusteriSoyad.Text);


                //Adres adres1 = new Adres(txtSokakNo.Text, txtAptNo.Text, txtDaireNo.Text, txtIl.Text, txtIlce.Text);
                //Sistem.m1.Adres.Add(adres1);

                Sistem.frmMusGiris.Show();
                this.Hide();
            }
            else
            {
                Sistem.frmMusKayit.Show();
            }
        }
    }
}
