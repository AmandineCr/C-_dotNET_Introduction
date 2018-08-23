using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTests
{
    class FakeName : INameProvider

    {
        public FakeName (string nameToReturn)
        {
            NameToReturn = nameToReturn;
        }

        public string NameToReturn { get; set; }

        public string Name => NameToReturn;
    }
}
