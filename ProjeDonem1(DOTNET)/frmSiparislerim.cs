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
    public partial class frmSiparislerim : Form
    {
        SqlConnection baglanti = new SqlConnection(Sistem.sqlbag);
        public frmSiparislerim()
        {
            InitializeComponent();
        }
        public void TabloGetir()
        {
            baglanti.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Siparislerim join Tbl_Musteriler on Tbl_Musteriler.KullaniciAdi = Tbl_Siparislerim.MusteriKullaniciAdi join Tbl_TumUrunler on Tbl_Siparislerim.Siparis_Urun_id = Tbl_TumUrunler.Urun_id join Tbl_Adresler on Tbl_Adresler.SokakNo = Tbl_Siparislerim.SiparisAdres where Musteri_KullaniciAdi = @b1", baglanti);
            da1.SelectCommand.Parameters.AddWithValue("@b1", Sistem.m1.KullaniciAdi);
            da1.SelectCommand.ExecuteNonQuery();
            DataTable tablo1 = new DataTable();
            da1.Fill(tablo1);
            dataGridView1.DataSource = tablo1;
            for (int i = 0; i < 9; i++)
            {
                tablo1.Columns.RemoveAt(0);
            }
            tablo1.Columns.RemoveAt(3);

            baglanti.Close();
        }
        private void frmSiparislerim_Load(object sender, EventArgs e)
        {
            TabloGetir();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sistem.frmSiparis = new frmSipraisAnaEkran();
            Sistem.frmSiparis.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand SiparisSil = new SqlCommand("delete from tbl_siparislerim where MusteriKullaniciAdi = @u1", baglanti);
            SiparisSil.Parameters.AddWithValue("@u1", Sistem.m1.KullaniciAdi);
            SiparisSil.ExecuteNonQuery();
            MessageBox.Show("Sipariş geçmişiniz temizlenmiştir.");
            
            baglanti.Close();
            TabloGetir();
        }
    }
}
