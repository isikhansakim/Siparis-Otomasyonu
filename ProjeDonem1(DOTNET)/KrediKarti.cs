using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDonem1_DOTNET_
{
    class KrediKarti
    {
        public string Isım { get; set; }
        public string SoyIsım { get; set; }
        public string KartNo { get; set; }
        public int CVV { get; set; }
        public DateTime SKT { get; set; }

        public KrediKarti(string Isım, string SoyIsım, string KartNo, int CVV, DateTime SKT)
        {
            this.Isım = Isım;
            this.SoyIsım = SoyIsım;
            this.KartNo = KartNo;
            this.CVV = CVV;
            this.SKT = SKT;
        }
    }
}
