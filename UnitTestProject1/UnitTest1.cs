using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expRes = 0;
            int actRes = MyClass.Add(0, 0);
            Assert.AreEqual(expRes, actRes, "Сумма посчитана не верно");
        }
        [TestMethod]
        public void TestMethod2()
        {
            int expRes = int.MaxValue;
            int actRes = MyClass.Add(int.MinValue, -1);
            Assert.AreEqual(expRes, actRes, "Сумма посчитана не верно");
        }
        [TestMethod]
        public void TestMethod3()
        {
            int expRes = 0;
            int actRes = MyClass.Add(0, 0);
            Assert.AreEqual(expRes, actRes, "Сумма посчитана не верно");
        }
        [TestMethod]
        public void TestMethod4()
        {
            int expRes = 0;
            int actRes = MyClass.Add(0, 0);
            Assert.AreEqual(expRes, actRes, "Сумма посчитана не верно");
        }
        [TestMethod]
        public void TestMethod5()
        {
            int expRes = 0;
            int actRes = MyClass.Add(0, 0);
            Assert.AreEqual(expRes, actRes, "Сумма посчитана не верно");
        }
        [TestMethod]
        public void TestMethod6()
        {
            int expRes = 0;
            int actRes = MyClass.Add(0, 0);
            Assert.AreEqual(expRes, actRes, "Сумма посчитана не верно");
        }
        [TestMethod]
        public void TestMethod7()
        {
            int expRes = 0;
            int actRes = MyClass.Add(0, 0);
            Assert.AreEqual(expRes, actRes, "Сумма посчитана не верно");
        }
        [TestMethod]
        public void TestMethod8()
        {
            int expRes = 0;
            int actRes = MyClass.Add(0, 0);
            Assert.AreEqual(expRes, actRes, "Сумма посчитана не верно");
        }
        [TestMethod]
        public void TestMethod9()
        {
            int expRes = 0;
            int actRes = MyClass.Add(0, 0);
            Assert.AreEqual(expRes, actRes, "Сумма посчитана не верно");
        }
        [TestMethod]
        public void TestMethod10()
        {
            int expRes = 0;
            int actRes = MyClass.Add(0, 0);
            Assert.AreEqual(expRes, actRes, "Сумма посчитана не верно");
        }
    }
}
