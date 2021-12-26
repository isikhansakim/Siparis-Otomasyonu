using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDonem1_DOTNET_
{
    class Urun
    {
        public string Ad { get; set; }
        public int Fiyat { get; set; }
        public string Aciklama { get; set; }
        public string Siparis_Urun_id { get; set; }

        /*public Urun(string Ad, int Fiyat, string Aciklama)
        {
            this.Ad = Ad;
            this.Fiyat = Fiyat;
            this.Aciklama = Aciklama;
        }*/

        public Urun (string Siparis_Urun_id)
        {
            this.Siparis_Urun_id = Siparis_Urun_id;
        }

    }
}
