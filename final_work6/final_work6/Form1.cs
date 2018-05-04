using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_work6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Personel p1 = new Personel();
            Calisan c1 = new Calisan();
            Mudur m1 = new Mudur();

            p1.MaasHesapla();
            c1.MaasHesapla();
            m1.MaasHesapla();

            MessageBox.Show("Müdür Maaşı : " + m1.Maas.ToString()+", Çalışan Maaşı : "+c1.Maas.ToString());



        }
    }
}
