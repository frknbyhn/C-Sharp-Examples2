using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace before_quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.MaasHesapla();
            MessageBox.Show(p.Maas.ToString());

            Calisan c = new Calisan();
            c.MaasHesapla();
            MessageBox.Show(c.Maas.ToString());

            Mudur m = new Mudur();
            m.MaasHesapla();
            MessageBox.Show(m.Maas.ToString());




            
        }
    }
}
