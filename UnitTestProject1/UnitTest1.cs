using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryFactorial;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Factorial n = new Factorial();
            long result = n.calculate(1);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Factorial n = new Factorial();
            long result = n.calculate(2);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Factorial n = new Factorial();
            long result = n.calculate(3);
            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Factorial n = new Factorial();
            long result = n.calculate(4);
            Assert.AreEqual(24, result);
        }
    }
}
