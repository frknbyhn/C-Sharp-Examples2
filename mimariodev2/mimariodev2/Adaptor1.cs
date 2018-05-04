using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimariodev2
{
    public class Adaptor1 : IDusman
    {
        DusmanRobotu dusmanrobotu;

        public Adaptor1(DusmanRobotu _dusmanrobotu)
        {
            this.dusmanrobotu = _dusmanrobotu;
        }

        public void SilahKullan()
        {
            dusmanrobotu.YumrukAt();
        }

        public void Hizlan()
        {
            dusmanrobotu.Yuru();
        }

        public void DusmanAdi()
        {
            dusmanrobotu.RobotIsim();
        }


    }
}
