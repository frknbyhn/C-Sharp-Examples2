using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mimariodev2
{
    public class DusmanTank:IDusman
    {
        public void SilahKullan()
        {
            MessageBox.Show("Düsman Tankı Silah Kullanıyor !");
        }

        public void Hizlan()
        {
            MessageBox.Show("Düşman Tankı Hızlanıyor !");
        }

        public void DusmanAdi()
        {
            MessageBox.Show("Düşman Tankı 'Tank1' ");
        }
    }
}
