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


    public partial class frmOdemeYontemi : Form
    {

        public frmOdemeYontemi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sistem.frmOdEkran = new frmOdemeEkrani();
            Sistem.frmOdEkran.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sistem.frmKapOd = new frmKapidaOdeme();
            Sistem.frmKapOd.Show();
            this.Hide();
        }
    }
}
