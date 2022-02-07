using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int N = 550;
            int result = Lab1ex2.Program.Example(N);
            Assert.AreEqual(9, result);
        }
    }
}
