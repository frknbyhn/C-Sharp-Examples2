using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel
{
    public class Isyeri
    {
        public string Adi { get; set; }
        public AdresSinifi AdresSinifi { get; set; } //Comp
        private List<Calisan> Calisanlar { get; set; } //Comp

        public Isyeri()
        {
            this.AdresSinifi = new AdresSinifi();
            this.Calisanlar = new List<Calisan>();
        }

        public void CalisanEkle (Calisan c)
        {
            Calisanlar.Add(c);
            

        }

        public string CalisanlariListele()
        {
            string temp = "";

            foreach (Calisan c in Calisanlar )
            {
                temp += "Adı:" + c.Isim + ", Departman" + c.Departman + Environment.NewLine;

            }

            return temp;

        }





    }
}
