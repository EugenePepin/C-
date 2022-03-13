using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLab2ex4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MinNumMas()

        {
            int[] mas = { -100, 2, 0, 10, 3 };
            Assert.AreEqual(1, Lab2ex3.Program.MinNumMas(mas));
        }
        [TestMethod]
        public void PlurToZeros()

        {
            int[] mas = { -100, 2, 0, 10, 3 };
            Assert.AreEqual(-200, Lab2ex3.Program.PlurToZero(mas));
            
        }
    }
}
