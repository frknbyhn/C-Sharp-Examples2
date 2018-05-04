using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using yazilim_sinama_proje;

namespace White_Box
{
    [TestClass]
    public class Controller_test
    {
        [TestMethod]
        public void CanInstantiateController()
        {
            Controller test = new Controller();

        }
        [TestMethod]
        public void Giris()
        {
            Controller test = new Controller();
            int sifre = test.txtPassword(123);
            Assert.AreEqual("123", sifre);
        }

        [TestMethod]
        public void demirbas_miktar()
        {
            Controller test = new Controller();
            int miktar = test.MiktarTxt(0);
            Assert.IsNotNull(miktar);
        }

        [TestMethod]
        public void demirbas_fiyat()
        {
            Controller test = new Controller();
            int fiyat = test.FiyatTXt(0);
            Assert.IsNotNull(fiyat);
        }


    }
}
