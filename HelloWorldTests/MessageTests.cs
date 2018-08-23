using HelloWorldTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HelloWorld.Tests
{
    [TestClass()]
    public class MessageTests
    {

        [TestMethod()]
        public void GetHelloMessageTest()
        {
            Message target = new Message();

            DateTime wedate = new DateTime(2018, 08, 25,16,0,0);
            FakeDateTime fakeDateTime = new FakeDateTime(wedate);
            target.DateTimeProvider = fakeDateTime;

            FakeName fakeName = new FakeName("Marie");
            target.NameProvider = fakeName;

            string result = target.GetHelloMessage();
            Assert.AreEqual(result, "Bon weekend ! Marie");

            fakeDateTime.DateToReturn = new DateTime(2018, 08, 22,16,0,0);
            result = target.GetHelloMessage();
            Assert.AreEqual(result, "Bon après-midi Marie");

            fakeDateTime.DateToReturn = new DateTime(2018, 08, 22, 9, 0, 0);
            result = target.GetHelloMessage();
            Assert.AreEqual(result, "Bonjour Marie");

            fakeDateTime.DateToReturn = new DateTime(2018, 08, 22, 20, 0, 0);
            result = target.GetHelloMessage();
            Assert.AreEqual(result, "Bonsoir Marie");
        }

        [TestMethod()]
        public void MessageTest()
        {

        }
    }
}