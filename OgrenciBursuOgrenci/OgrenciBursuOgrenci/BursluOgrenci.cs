using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBursuOgrenci
{
    public class BursluOgrenci:Ogrenci
    {
        public decimal BursOrani { get; set; }
        public decimal BursIndirimi { get; private set; }

        public override void DersUcretiHesapla()
        {
            base.DersUcretiHesapla();
            this.BursIndirimi = DersUcreti * BursOrani;
            dersucreti = DersUcreti - BursIndirimi;
        }
    }
}
