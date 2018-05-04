using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_work2
{
    class Isci
    {
        public long KimlikNo { get; set; }
        public decimal AsgariGeciIndirimi { get; private set; }
        public short CocukSayisi { get; private set; }

        public Isci(short cocuk)
        {
            this.CocukSayisi = cocuk;
            AsgariGecimIndirimiHesapla();
        }

        private void AsgariGecimIndirimiHesapla()
        {
            if (CocukSayisi == 0)
                AsgariGeciIndirimi = 80.33M;
            else if (CocukSayisi > 1)
                AsgariGeciIndirimi = 104.42M;
        }

    }
}
