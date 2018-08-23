using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTests
{
    class RealDateTime : IDateTimeProvider
    {
        public DateTime Date
        {
            get {
                return DateTime.Now;
                }
        }
    }
}
