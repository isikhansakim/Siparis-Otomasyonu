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
    public partial class frmKullaniciBilgileri : Form
    {

      
        
        public frmKullaniciBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Sistem.sqlbag);
        private void frmKullaniciBilgileri_Load(object sender, EventArgs e)
        {


            //ReadAdresData();


            lblAdS.Text = Sistem.m1.Ad;
            lblSoyadS.Text = Sistem.m1.Soyad;
            lblKullaniciAdS.Text = Sistem.m1.KullaniciAdi;
            lblAcikAdresS.Text = "";

            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT * From Tbl_Musteriler Join Tbl_Adresler On Tbl_Adresler.Musteri_KullaniciAdi = Tbl_Musteriler.KullaniciAdi where KullaniciAdi = @a1;", baglanti);
            komut.Parameters.AddWithValue("@a1", Sistem.m1.KullaniciAdi);




            SqlDataReader reader = komut.ExecuteReader();

            // Read fonksiyonunu veriye ulaşmadan önce çağır
            while (reader.Read())
            {
                lblAcikAdresS.Text += "Adres: " + reader[5].ToString() + " sokak " + "No: " + reader[6].ToString() + " Daire: " + reader[7].ToString() + " " + reader[8].ToString() + "/" + reader[9].ToString();
                lblAcikAdresS.Text += "\n";  
            }

            // Okuma tamamlandığında close fonksiyonunu çağır
            reader.Close();
            baglanti.Close();


            


        }


    }


}
