using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_work7
{
    public abstract class Kisi
    {
        public string Isim { get; set; }

        public virtual string BilgiGoster()
        {
            return "İsim : " + this.Isim;
        }
    }
}
