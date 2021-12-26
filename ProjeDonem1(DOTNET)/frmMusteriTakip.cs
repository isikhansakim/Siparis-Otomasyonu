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
    public partial class frmMusteriTakip : Form
    {
        SqlConnection baglanti = new SqlConnection(Sistem.sqlbag);

        public frmMusteriTakip()
        {
            InitializeComponent();
        }

        private void frmMusteriTakip_Load(object sender, EventArgs e)
        {


            baglanti.Open();
            


            SqlDataAdapter da = new SqlDataAdapter("SELECT * From Tbl_Musteriler; ", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            tablo.Columns.RemoveAt(1);
            tablo.Columns.RemoveAt(1);
            tablo.Columns.RemoveAt(1);

            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string value1 = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                value1 = row.Cells[0].Value.ToString();
            }

            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Siparislerim join Tbl_Musteriler on Tbl_Musteriler.KullaniciAdi = Tbl_Siparislerim.MusteriKullaniciAdi join Tbl_TumUrunler on Tbl_Siparislerim.Siparis_Urun_id = Tbl_TumUrunler.Urun_id join Tbl_Adresler on Tbl_Adresler.SokakNo = Tbl_Siparislerim.SiparisAdres where Musteri_KullaniciAdi = @b1", baglanti);
            da1.SelectCommand.Parameters.AddWithValue("@b1", value1);
            da1.SelectCommand.ExecuteNonQuery();
            DataTable tablo1 = new DataTable();
            da1.Fill(tablo1);
            dataGridView1.DataSource = tablo1;
            tablo1.Columns.RemoveAt(0);
            tablo1.Columns.RemoveAt(0);
            tablo1.Columns.RemoveAt(0);
            tablo1.Columns.RemoveAt(4);
            tablo1.Columns.RemoveAt(7);



            baglanti.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sistem.frmCalSec.Show();
            this.Hide();
        }
    }
}
