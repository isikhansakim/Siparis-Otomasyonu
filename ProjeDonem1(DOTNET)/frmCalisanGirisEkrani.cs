using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeDonem1_DOTNET_
{
    public partial class frmCalisanGirisEkrani : Form
    {
        public frmCalisanGirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                Sistem.frmCalSec = new frmCalisanSecim();
                Sistem.frmCalSec.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girdiğiniz Şifre Hatalıdır lütfen tekrar deneyiniz.");
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sistem.frm1.Show();
            this.Hide();
        }
    }
}
