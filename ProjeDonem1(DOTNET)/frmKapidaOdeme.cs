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
    public partial class frmKapidaOdeme : Form
    {
        SqlConnection baglanti = new SqlConnection(Sistem.sqlbag);

        public frmKapidaOdeme()
        {
            InitializeComponent();
        }

        private void frmKapidaOdeme_Load(object sender, EventArgs e)
        {


            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("SELECT * From Tbl_Musteriler Join Tbl_Adresler On Tbl_Adresler.Musteri_KullaniciAdi = Tbl_Musteriler.KullaniciAdi where KullaniciAdi = @a1;", baglanti);
            komut1.Parameters.AddWithValue("@a1", Sistem.m1.KullaniciAdi);


            SqlDataReader reader1 = komut1.ExecuteReader();

            // Read fonksiyonunu veriye ulaşmadan önce çağır
            while (reader1.Read())
            {
                cmbAdres.Items.Add("Adres: " + reader1[5].ToString() + " sokak " + "No: " + reader1[6].ToString() + " Daire: " + reader1[7].ToString() + " " + reader1[8].ToString() + "/" + reader1[9].ToString());

            }

            // Okuma tamamlandığında close fonksiyonunu çağır
            reader1.Close();
            baglanti.Close();

            lblAdS.Text = Sistem.m1.Ad;
            lblSoyadS.Text = Sistem.m1.Soyad;
            lblKullaniciAdS.Text = Sistem.m1.KullaniciAdi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = cmbAdres.SelectedItem.ToString();
            string[] bol = x.Split(' ');
            string SokakNomuz = bol[1];
            List<int> Urun_id = new List<int>();


            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from Tbl_Sepetim where Musteri_KullaniciAdi = @a1", baglanti);
            komut.Parameters.AddWithValue("@a1", Sistem.m1.KullaniciAdi);
            SqlDataReader SepetOku = komut.ExecuteReader();

            while (SepetOku.Read())
            {
                Urun_id.Add(Convert.ToInt32(SepetOku[1]));
            }



            SepetOku.Close();
            for (int j = 0; j < Urun_id.Count; j++)
            {
                SqlCommand SiparisEkle = new SqlCommand("insert into Tbl_Siparislerim (MusteriKullaniciAdi, Siparis_Urun_id, SiparisAdres) values (@s1, @s2, @s3)", baglanti);
                SiparisEkle.Parameters.AddWithValue("@s1", Sistem.m1.KullaniciAdi);
                SiparisEkle.Parameters.AddWithValue("@s2", Urun_id[j]);
                SiparisEkle.Parameters.AddWithValue("@s3", SokakNomuz);
                SiparisEkle.ExecuteNonQuery();
            }

            SqlCommand SepetTemizle = new SqlCommand("delete from Tbl_Sepetim where Musteri_KullaniciAdi = @z1", baglanti);
            SepetTemizle.Parameters.AddWithValue("@z1", Sistem.m1.KullaniciAdi);
            SepetTemizle.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Siparişiniz alınmıştır.");
            Sistem.frmSiparis.Show();
            this.Hide();

            
        }

        private void lnklblAnaSayfa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sistem.frmSiparis.Show();
            this.Hide();
        }
    }
}
