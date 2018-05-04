using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriHesaplamalar
{
    
    public abstract class GeometriHesaplamalar
    {
        protected double cevre { get; set; }
        public double Cevre { get; private set; }
        protected double alan { get; set; }
        public double Alan { get; private set; }

        public abstract void CevreHesapla(double deger1, double deger2);
        public abstract void AlanHesapla(double deger1, double deger2);



    }
}
