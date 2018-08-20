using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{


    class Message
    {

        private string helloMessage = "coucou";
        public Message(string helloMessage) => HelloMessage = helloMessage;

        public string HelloMessage
        {
            get { return helloMessage; }
            set { helloMessage = value; }
        }
    }
}


