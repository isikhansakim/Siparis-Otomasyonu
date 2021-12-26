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
    public partial class frmSepetim : Form
    {
        SqlConnection baglanti = new SqlConnection(Sistem.sqlbag);

        void SepetGetir()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From Tbl_TumUrunler Join Tbl_Sepetim On Tbl_Sepetim.Sepet_Urun_id = tbl_TumUrunler.Urun_id where Musteri_KullaniciAdi = @a1; ", baglanti);
            da.SelectCommand.Parameters.AddWithValue("@a1", Sistem.m1.KullaniciAdi);
            da.SelectCommand.ExecuteNonQuery();
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            tablo.Columns.RemoveAt(0);
            tablo.Columns.RemoveAt(3);
            tablo.Columns.RemoveAt(3);


            baglanti.Close();
                
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string value1 = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                value1 = row.Cells[3].Value.ToString();
            }

            baglanti.Open();

            SqlCommand SepetSil = new SqlCommand("delete from tbl_sepetim where Sepet_id = @s1",baglanti);
            SepetSil.Parameters.AddWithValue("@s1", value1);
            SepetSil.ExecuteNonQuery();
            
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SepetGetir();
        }

        public frmSepetim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sistem.frmOdYon = new frmOdemeYontemi();
            Sistem.frmOdYon.Show();
            this.Hide();
        }

        private void frmSepetim_Load(object sender, EventArgs e)
        {
            
            SepetGetir();


            /*int urunSayisi = Sistem.m1.Sepet.Count();

            if (urunSayisi == 0)
            {
                lblUrun1.Text = "Sepetiniz Boş";
            }
            else
            {
                string sonuc = "";

                for (int i = 0; i < urunSayisi; i++)
                {
                    Urun urun = Sistem.m1.Sepet[i];
                    sonuc += urun.Ad + " " + urun.Fiyat + "\n" + urun.Aciklama + "\n";
                }

                lblUrun1.Text = sonuc;

            }*/
        }
        
   
        private void lnklblAnaSayfa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sistem.frmSiparis.Show();
            this.Hide();
        }


    }
}
