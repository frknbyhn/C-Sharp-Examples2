using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_work7
{
    public class Mudur:Kisi,ICalisabilen
    {
        public string Calis()
        {
            return "Yönetirim";
        }

        public override string BilgiGoster()
        {
            return base.BilgiGoster();
        }


    }
}
