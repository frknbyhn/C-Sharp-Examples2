using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Isyeri i = new Isyeri();
            i.Adi = "BlueSoft";
            i.AdresSinifi.Il = "Bursa";
            i.AdresSinifi.Ilce = "Nilüfer";
            i.AdresSinifi.Mahalle = "Çamlıca";

            Calisan c1 = new Calisan();
            c1.Isim = "MrX";
            c1.Departman = "Yazilim";
            c1.Gorev = "Yazılım Uzmanı";
            c1.Isyeri = i;

            Calisan c2 = new Calisan();
            c2.Isim = "MrsY";
            c2.Departman = "Yazilim";
            c2.Gorev = "Test Uzmanı";
            c2.Isyeri = i;

            i.CalisanEkle(c1);
            i.CalisanEkle(c2);

            MessageBox.Show(i.CalisanlariListele());






        }
    }
}
