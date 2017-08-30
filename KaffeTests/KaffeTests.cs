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
            int pris = kaffe.Pris();
            //Assert
            Assert.AreEqual(20, pris);
        }

        [TestMethod()]
        public void styrkeTestKaffe()
        {
            var kaffe = new SortKaffe();

            string styrke = kaffe.Styrke();

            Assert.AreEqual("Stærk", styrke);
        }

        [TestMethod()]
        public void styrkeTestKaffeListe()
        {
            //Arrange
            var kaffeListe = new List<Imælk>();
            var cortado = new Cortado();
            var latte = new Latte();
            var sortKaffe = new SortKaffe();
            kaffeListe.Add(cortado);
            kaffeListe.Add(latte);
            //kaffeListe.Add(sortKaffe);

            //Act
            int Total = 0;
            foreach (var kaffeitem in kaffeListe)
            {
                Total += kaffeitem.M1Mælk();
                //if (kaffeitem is Cortado)
                //{
                //    var cortardo2 = kaffeitem as Cortado;
                //}
                //kaffeitem.M1Mælk();
            }

            //Assert
            Assert.AreEqual(145, Total);
        }
    }
}