using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    public abstract class Hayvan
    {
        public string Adi { get;private set; }
        public string Cins { get; set; }

        public Hayvan(string ad)
        {
            this.Adi = ad;
        }

        public Hayvan() { }

        public abstract string SesCikar();

    }
}
