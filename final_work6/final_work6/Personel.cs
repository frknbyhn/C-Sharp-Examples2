using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_work6
{
    public class Personel
    {
        public string Isim { get; set; }
        public decimal Maas { get; private set; }
        
        protected decimal maas = 0;
        public Personel()
        {
          
        }

        public virtual void MaasHesapla()
        {
            maas=0;
        }

    }
}
