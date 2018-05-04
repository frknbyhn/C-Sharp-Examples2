using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel
{
    public class Kisi
    {
        public ulong TCKimlikNo { get; set; }
        public string Isim { get; set; }
        public AdresSinifi AdresSinifi { get; set; }
        public Kisi()
        {
            this.AdresSinifi = new AdresSinifi();   //Composition
        }
    }
}
