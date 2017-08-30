using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe.Tests
{
    [TestClass()]
    public class KaffeTests
    {
        [TestMethod()]
        public void prisTestKaffe()
        {
            //Arrange
            var kaffe = new SortKaffe();
            //Act
            int pris = kaffe.pris();
            //Assert
            Assert.AreEqual(20, pris);
        }

        [TestMethod()]
        public void styrkeTestKaffe()
        {
            var kaffe = new SortKaffe();

            string styrke = kaffe.styrke();

            Assert.AreEqual("Stærk", styrke);
        }
    }
}