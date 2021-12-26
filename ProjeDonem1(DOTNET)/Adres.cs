using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDonem1_DOTNET_
{
    class Adres
    {
        public string SokakNo { get; set; }
        public string ApartmanNo { get; set; }
        public string DaireNo { get; set; }
        public string Ilce { get; set; }
        public string Il { get; set; }

        public Adres(string SokakNo, string AptNo, string DaireNo, string Il, string Ilce)
        {
            this.SokakNo = SokakNo;
            this.ApartmanNo = AptNo;
            this.DaireNo = DaireNo;
            this.Il = Il;
            this.Ilce = Ilce;
        }
    }
}
