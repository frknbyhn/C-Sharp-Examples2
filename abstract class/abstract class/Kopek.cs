using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    public class Kopek:Hayvan
    {
        public Kopek(string kopekAdi) : base(kopekAdi) { }


        public override string SesCikar()
        {
            return "hac hav";
        }
    }
}
