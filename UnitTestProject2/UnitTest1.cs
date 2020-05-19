using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            float[] a = { 3, 8, 0, -12, 3, 33 };
            int m = 6;

            float result = Rus_OOP_Lab_2._3._1.Program.Second(a, m);
            Assert.AreEqual(24, result);
        }
    }
}
