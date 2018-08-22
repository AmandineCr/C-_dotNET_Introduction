using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHelloWorld
{
    [TestClass]
    class FakeClassB : IClassB
    {
        public FakeClassB()
        {
        }

        public string DataToReturn { get; set; }

        // Herité de la IclassB
        public string GetData()
        {
            return DataToReturn;
        }
    }

}
