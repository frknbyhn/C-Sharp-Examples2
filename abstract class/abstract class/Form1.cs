using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abstract_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void KopekBilgisiGoster(Kopek k)
        {
            MessageBox.Show("adi:" + k.Adi + "\n Cinsi:" + k.Cins + "\ndiye bağırır." + k.SesCikar());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kopek k = new Kopek("Co");
            k.Cins = "buldog";
            k.SesCikar();
            KopekBilgisiGoster(k);

        }
    }
}
