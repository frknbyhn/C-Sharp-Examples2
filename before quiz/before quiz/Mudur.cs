using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace before_quiz
{
    class Mudur:Personel
    {
        public Mudur()
        {
                
        }

        public override void MaasHesapla()
        {
            base.MaasHesapla();
            maas *= 4M;
        }
    }
}
