using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel
{
    public class Calisan : Kisi
    {
        public ulong SGKNo { get; set; }
        public string Gorev { get; set; }
        public string Departman { get; set; }
        public Isyeri Isyeri { get; set; }
        public Calisan()
        {
            this.Isyeri = new Isyeri();
        }
    }
}
