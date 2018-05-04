using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    public class Kedi:Hayvan
    {
        public Kedi(string kediAdi) : base(kediAdi) { }

        public override string SesCikar()
        {
            return "miyav";
        }
    }
}
