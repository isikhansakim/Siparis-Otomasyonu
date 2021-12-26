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
    public partial class frmKrediKartiEkleme : Form
    {
        public frmKrediKartiEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Sistem.sqlbag);
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into tbl_Kartlar (Musteri_KullaniciAdi,Isim,Soyisim,KartNo,CVV,SKT) values (@a1,@a2,@a3,@a4,@a5,@a6)", baglanti);
            komut.Parameters.AddWithValue("@a1", Sistem.m1.KullaniciAdi);
            komut.Parameters.AddWithValue("@a2", txtIsım.Text);
            komut.Parameters.AddWithValue("@a3", txtSoyIsım.Text);
            komut.Parameters.AddWithValue("@a4", mskdKKNo.Text);
            komut.Parameters.AddWithValue("@a5", mskdCVV.Text);
            komut.Parameters.AddWithValue("@a6", Convert.ToDateTime(mskdSKT.Text));
            komut.ExecuteNonQuery();

            baglanti.Close();

            Sistem.frmSiparis.Show();
            this.Hide();

            /*KrediKarti krediKarti1 = new KrediKarti(txtIsım.Text, txtSoyIsım.Text,
                                                    mskdKKNo.Text,
                                                    Convert.ToInt32(mskdCVV.Text),
                                                    Convert.ToDateTime(mskdSKT.Text));

            Sistem.m1.KrediKartlari.Add(krediKarti1);*/
        }
    }
}
