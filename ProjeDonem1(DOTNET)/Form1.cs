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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sistem.frmMusGiris = new frmMusteriGirisEkrani();
            Sistem.frmMusGiris.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sistem.frmCalGir = new frmCalisanGirisEkrani();
            Sistem.frmCalGir.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sistem.frm1 = new Form1();
        }
    }
}
