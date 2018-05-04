using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urun
{
    class Telefon:Urun
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public Telefon()
        {

        }

        public override string TelefonValidasyon()
        {
            return base.TelefonValidasyon();
        }

    }
}
