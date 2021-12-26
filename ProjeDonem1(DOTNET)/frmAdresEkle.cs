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
    public partial class frmAdresEkle : Form
    {
        public frmAdresEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Sistem.sqlbag);

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into tbl_Adresler(SokakNo, ApartmanNo, DaireNo, Il, Ilce, Musteri_KullaniciAdi) values(@b1, @b2, @b3, @b4, @b5, @b6)", baglanti);
            komut1.Parameters.AddWithValue("@b1", txtSokakNo.Text);
            komut1.Parameters.AddWithValue("@b2", txtAptNo.Text);
            komut1.Parameters.AddWithValue("@b3", txtDaireNo.Text);
            komut1.Parameters.AddWithValue("@b4", txtIl.Text);
            komut1.Parameters.AddWithValue("@b5", txtIlce.Text);
            komut1.Parameters.AddWithValue("@b6", Sistem.m1.KullaniciAdi);

            komut1.ExecuteNonQuery();

            baglanti.Close();

            //Adres adres1 = new Adres(txtSokakNo.Text, txtAptNo.Text, txtDaireNo.Text, txtIl.Text, txtIlce.Text);
            //Sistem.m1.Adres.Add(adres1);
       
            Sistem.frmSiparis.Show();
            this.Hide();

            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sistem.frmSiparis.Show();
            this.Hide();
        }
    }
}
