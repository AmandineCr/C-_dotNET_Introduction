using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            for (string i = ""; i != "exit"; i = Console.ReadLine())
            {

                Message message = new Message(morning: 3, evening: 14);

                Console.WriteLine(message.GetHelloMessage());

            }
        }
    }
}
