using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bulletin; 

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calcules c = new Calcules();
            double m = c.CalculerMoyenne(11, 11, 12);
            Assert.AreEqual( m , 11.2);
                
         }

        [TestMethod]
        public void TestMethod2()
        {
            Calcules c = new Calcules();
            double[] matieres = {11 , 11, 11 };
            double m = c.CalculerMoyenneMultiple(matieres);
            Assert.AreEqual(m, 11);

        }
    }
}
