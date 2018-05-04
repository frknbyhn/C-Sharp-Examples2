using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriHesaplamalar
{
    public class Dikdortgen:GeometriHesaplamalar
    {
        public override void AlanHesapla(double deger1, double deger2)
        {
            alan = deger1 * deger2;
        }

        public override void CevreHesapla(double deger1, double deger2)
        {
            cevre=2*(deger1+deger2);
        }


    }
}
