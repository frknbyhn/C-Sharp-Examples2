using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mimariodev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DusmanRobotu drobot = new DusmanRobotu();
            Adaptor1 adaptor = new Adaptor1(drobot);

            adaptor.DusmanAdi();
            adaptor.Hizlan();
            adaptor.SilahKullan();

            DusmanTank dtank = new DusmanTank();
            dtank.DusmanAdi();
            dtank.Hizlan();
            dtank.SilahKullan();

        }
    }
}
