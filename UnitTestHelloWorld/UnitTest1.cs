using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHelloWorld
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FakeClassB fake = new FakeClassB();
            fake.DataToReturn = "my test value";
            ClassA target = new ClassA(fake);
            string result = target.DoSomethingA();
            Assert.AreEqual("my test value", result);
        }
    }
}
