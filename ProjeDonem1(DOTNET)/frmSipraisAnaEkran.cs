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
    public partial class frmSipraisAnaEkran : Form
    {
        SqlConnection baglanti = new SqlConnection(Sistem.sqlbag);

        public frmSipraisAnaEkran()
        {
            InitializeComponent();
        }

        
        
        private void krediKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKrediKartiEkleme f = new frmKrediKartiEkleme();
            f.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string value1 = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                value1 = row.Cells[0].Value.ToString();
            }
            baglanti.Open();
            
            
            //SqlCommand UrunSepet = new SqlCommand("SELECT * From Tbl_TumUrunler Join Tbl_Sepetim On Tbl_Sepetim.Sepet_Urun_id = tbl_TumUrunler.Urun_id where Urun_id = '1'; ", baglanti);
            SqlCommand SepeteEkle = new SqlCommand("insert into Tbl_Sepetim (Musteri_KullaniciAdi, Sepet_Urun_id) values (@u1, @u2)", baglanti);
            SepeteEkle.Parameters.AddWithValue("@u1", Sistem.m1.KullaniciAdi);
            SepeteEkle.Parameters.AddWithValue("@u2", value1);
            SepeteEkle.ExecuteNonQuery();
            
            baglanti.Close();


            /*string valuea = "", valueb = "";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                value1 = row.Cells[1].Value.ToString();
                value2 = row.Cells[2].Value.ToString();
                Urun urun = new Urun(valuea, Convert.ToInt32(valueb));
                Sistem.m1.Sepet.Add(urun);
            }*/

        }

        private void kullanıcıBilgilerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistem.frmKulBil = new frmKullaniciBilgileri();
            Sistem.frmKulBil.Show();
        }

        private void adresEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistem.frmAdEkle = new frmAdresEkle();
            Sistem.frmAdEkle.Show();
            this.Hide();
        }

        private void sepetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSepetim().Show();
            this.Hide();
        }

        private void frmSipraisAnaEkran_Load(object sender, EventArgs e)
        {
            

            baglanti.Open();
            
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From Tbl_TumUrunler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

            
            SqlCommand komut = new SqlCommand("SELECT * From Tbl_Musteriler where KullaniciAdi = @a1;", baglanti);
            komut.Parameters.AddWithValue("@a1", Sistem.KulAd);



            SqlDataReader reader = komut.ExecuteReader();
            reader.Read();


            string KullaniciAd = reader[0].ToString();
            string Sifre = reader[1].ToString();
            string Ad = reader[2].ToString();
            string Soyad = reader[3].ToString();


            reader.Close();
            komut.ExecuteNonQuery();

            baglanti.Close();

            if (Sistem.m1 == null)
            {
                Sistem.m1 = new Musteri(KullaniciAd, Sifre, Ad, Soyad);
            }
            else
            {
                Sistem.m1.KullaniciAdi = KullaniciAd;
                Sistem.m1.Sifre = Sifre;
                Sistem.m1.Ad = Ad;
                Sistem.m1.Soyad = Soyad;
                
            }

            
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistem.frmMusGiris.Show();
            this.Hide();
        }

        private void kapıdaÖdemeNakitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistem.frmKulBil = new frmKullaniciBilgileri();
            Sistem.frmKulBil.Show();
        }

        private void sipraişlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistem.frmSip = new frmSiparislerim();
            Sistem.frmSip.Show();
            this.Hide();
        }
    }
}
