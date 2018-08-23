using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTests
{
    public interface IDateTimeProvider
    {
        DateTime Date { get; }
    }
}
