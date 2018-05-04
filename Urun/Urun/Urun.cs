using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urun
{
    public class Urun
    {
        public int No { get; private set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public decimal Fiyat { get; set; }
        public Urun()
        {

        }

        public virtual string TelefonValidasyon();

    }
}
