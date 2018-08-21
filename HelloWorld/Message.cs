using System;

namespace HelloWorld
{


    public class Message
    {

        public string newMsg;

        public Message(string msg)
        {
            newMsg = msg;

        }

        public string ShowMsg()
        {
            return newMsg;


        }
    }
}


