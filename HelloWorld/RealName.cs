using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class RealName : INameProvider
    {
        public string Name {
            get
            {
                return Environment.UserName;
            }

        }
    }
}
