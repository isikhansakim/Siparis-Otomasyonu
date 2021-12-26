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
    public partial class frmCalisanSecim : Form
    {
        public frmCalisanSecim()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sistem.frmMusTak = new frmMusteriTakip();
            Sistem.frmMusTak.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sistem.frmCalEk = new frmCalisanAnaEkrani();
            Sistem.frmCalEk.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sistem.frmCalGir.Show();
            this.Hide();
        }
    }
}
