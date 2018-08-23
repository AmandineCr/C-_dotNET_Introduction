using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld;

namespace HelloWorldTests
{
    class FakeDateTime : IDateTimeProvider
    {
        public FakeDateTime(DateTime dateToReturn)
        {
            DateToReturn = dateToReturn;
        }

        public DateTime DateToReturn { get; set; }

        public DateTime Date => DateToReturn;
    }
}
