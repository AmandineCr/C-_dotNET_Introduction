using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
          
            string line ="";
            do
            {
                if (line == "")
                {
                    Message message = new Message(morning: 3, evening: 14);
                    Console.WriteLine(message.GetHelloMessage());
                }
                else
                {
                    Console.WriteLine("Error try again");
                }

                line = Console.ReadLine();
            }
            while (line != "exit");
        }

    }
}
