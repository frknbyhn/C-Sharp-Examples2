using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBursuOgrenci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.KrediSayisi = 14;
            o.DersUcretiHesapla();
            MessageBox.Show(o.DersUcreti.ToString());

            BursluOgrenci b=new BursluOgrenci()
            {
                BursOrani=0.1M,
                KrediSayisi=14,

            };

            b.DersUcretiHesapla();
            MessageBox.Show(b.BursIndirimi.ToString()+b.DersUcreti.ToString());




        }
    }
}
