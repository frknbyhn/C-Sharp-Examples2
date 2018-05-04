using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_work7
{
    public class Cocuk:Kisi,ICalisabilen,IOynayabilen
    {
        public string Calis()
        {
            return "Ders Çalış";
        }

        public string Oyna()
        {
            return "Top Oyna";
        }

    }
}
