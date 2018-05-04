using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _this
{
    class Kitap
    {
        public decimal Fiyat { get; private set; }
        public decimal VergiTutari { get; private set; }
        private decimal VERGIORANI { get; private set; }

        public void FiyatveVergiHesapla(decimal fiyat)
        {
            this.Fiyat = Fiyat;
            this.VergiTutari = this.Fiyat * VERGIORANI;
        }

    }
}
