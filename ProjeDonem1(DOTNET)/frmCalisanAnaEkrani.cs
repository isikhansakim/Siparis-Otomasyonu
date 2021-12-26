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
    public partial class frmCalisanAnaEkrani : Form
    {
        public frmCalisanAnaEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Sistem.sqlbag);


        private void btnUrunListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * From Tbl_TumUrunler", baglanti);
            DataTable tablo1 = new DataTable();
            da1.Fill(tablo1);
            dataGridView1.DataSource = tablo1;
            baglanti.Close();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutekle = new SqlCommand("insert into tbl_tumurunler (Ad, Fiyat, Aciklama) values (@a1, @a2, @a3)", baglanti);
            komutekle.Parameters.AddWithValue("@a1", textBox1.Text);
            komutekle.Parameters.AddWithValue("@a2", textBox2.Text);
            komutekle.Parameters.AddWithValue("@a3", textBox4.Text);
            komutekle.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Ürün Başarıyla Eklendi");
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutsil = new SqlCommand("delete from tbl_tumurunler where Urun_id = @b1",baglanti);
            komutsil.Parameters.AddWithValue("@b1", textBox3.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ürün Başarıyla Silindi");
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutguncelle = new SqlCommand("update tbl_tumurunler set Ad=@c1, Fiyat=@c2, Aciklama=@c3 where Urun_id = @c4", baglanti);
            komutguncelle.Parameters.AddWithValue("@c4", textBox3.Text);
            komutguncelle.Parameters.AddWithValue("@c1", textBox1.Text);
            komutguncelle.Parameters.AddWithValue("@c2", textBox2.Text);
            komutguncelle.Parameters.AddWithValue("@c3", textBox4.Text);
            komutguncelle.ExecuteNonQuery();

            baglanti.Close();
        }

      
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox3.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox3.Focus();
        }

        private void frmCalisanAnaEkrani_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From Tbl_TumUrunler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sistem.frmCalSec.Show();
            this.Hide();
        }
    }
}
