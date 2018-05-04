using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_work7
{
    public class Ogretmen:Kisi,ICalisabilen
    {
        public string Calis()
        {
            return "Öğretirim";
        }

        public override string BilgiGoster()
        {
            return base.BilgiGoster();
        }


    }
}
