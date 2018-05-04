using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_work7
{
    public class Satisci:Kisi,ICalisabilen
    {
        public string Calis()
        {
            return "Satış Yaparım...";
        }

        public override string BilgiGoster()
        {
            return base.BilgiGoster();
        } 
    }
}
