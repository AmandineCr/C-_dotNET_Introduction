using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Tests
{
    [TestClass()]
    public class MessageTests
    {
        
        [TestMethod()]
        public void GetHelloMessageTest()
        {
            Message target = new Message();
            string result = target.GetHelloMessage();
            Assert.AreEqual(result, "Bonjour amandine.cesar" );
        }

        [TestMethod()]
        public void MessageTest()
        {
           
        }
    }
}