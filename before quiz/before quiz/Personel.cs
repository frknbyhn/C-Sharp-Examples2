using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace before_quiz
{
    class Personel
    {
        private const decimal ASGARIUCRET = 1000;
        private const decimal AILEGECIMINDIRIMI = 500;


        public string Isim { get; set; }
        protected decimal maas { get; set; }
        public decimal Maas { get; private set; }

        public Personel()
        {

        }
        
        public virtual void MaasHesapla()
        {
            maas = ASGARIUCRET + AILEGECIMINDIRIMI;
        }

    }
}
