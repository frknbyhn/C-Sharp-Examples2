using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urun
{
    public class Kitap:Urun
    {
        public int ISBN { get; set; }
        public string Yazar { get; set; }
        public Kitap()
        {

        }

        public override string KitapValidasyon()
        {
            return base.TelefonValidasyon();
        }
    }
}
