using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace before_quiz
{
    class Calisan:Personel
    {
        public Calisan()
        {

        }

        public override void MaasHesapla()
        {
            base.MaasHesapla();
            maas *= 1.5M;
        }

    }
}
