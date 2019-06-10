using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const int Expected = 25;

        [TestMethod]
        public void TestMethod1()
        {
            int cant = 1;
            int precio = 25;
            int sub = cant * precio;


            Assert.AreEqual(Expected, sub);
        }
    }
}
