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
    public partial class frmMusteriGirisEkrani : Form
    {



        SqlConnection baglanti = new SqlConnection(Sistem.sqlbag);

        public frmMusteriGirisEkrani()
        {
            InitializeComponent();
        }

        private void lblUyeOl_LinkClicked(object sender, EventArgs e)
        {
            Sistem.frmMusKayit = new frmMusteriKayitEkrani();
            Sistem.frmMusKayit.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            
            
            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT * From Tbl_Musteriler where KullaniciAdi = @a1;", baglanti);
            komut.Parameters.AddWithValue("@a1", txtKullaniciAdi.Text);

            
            
            SqlDataReader reader = komut.ExecuteReader();
            reader.Read();

            
            Sistem.KulAd = reader[0].ToString();
            Sistem.KulSifre = reader[1].ToString();

            
            reader.Close();
            komut.ExecuteNonQuery();

            baglanti.Close();


            /*if (Sistem.m1 == null)
            {
                MessageBox.Show("Giriş yapmadan önce üye olmanız gerekmetedir.");
                Sistem.frmMusGiris.Show();
            }*/

            if ((txtKullaniciAdi.Text == Sistem.KulAd) && (txtSifre.Text == Sistem.KulSifre))
            {
                Sistem.frmSiparis = new frmSipraisAnaEkran();
                Sistem.frmSiparis.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Girdiğiniz Kullanıcı Adı veya Parola yanlış tülfen tekrar deneyiniz");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sistem.frm1.Show();
            this.Hide();
        }
    }
}
