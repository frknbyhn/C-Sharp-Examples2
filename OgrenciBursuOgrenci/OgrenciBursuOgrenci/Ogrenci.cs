using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBursuOgrenci
{
    public class Ogrenci
    {
        private const decimal BIRIMDERSUCRETI = 55.75M;
        public string Isim { get; set; }
        public short KrediSayisi { get; set; }
        public decimal DersUcreti{ get; private set; }

        protected decimal dersucreti = 0;
        public virtual void DersUcretiHesapla()
        {
            dersucreti = this.KrediSayisi * BIRIMDERSUCRETI;
        }
    }
}
