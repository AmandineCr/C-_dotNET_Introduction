using System;
using System.Collections.ObjectModel;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Message message = new Message("blabla");

            message.Bonjour = "HEEEEELLLLO";

            string msg = message.Name;

            Console.WriteLine(msg);
            Console.WriteLine(message.Msg);
            Console.ReadKey();

            //DateTime localDate = DateTime.Now;
            //Boolean morning = localDate.Hour >= 9 && localDate.Hour < 13;
            //Boolean afternoon = localDate.Hour >= 13 && localDate.Hour <= 18;

            //DayOfWeek today = localDate.DayOfWeek;
            //Collection<DayOfWeek> daysOfWeekend = new Collection<DayOfWeek>
            //{
            //    DayOfWeek.Saturday,
            //    DayOfWeek.Sunday
            //};

            //if (daysOfWeekend.Contains(today))
            //    Console.WriteLine("Bon weekend !");
            //else
            //    if (morning)
            //{
            //    Console.WriteLine("Bonjour c'est le matin");
            //    Message sayHello = new Message("Hello");
            //    Console.WriteLine(sayHello.ShowMsg());
            //}

            //else if (afternoon)
            //    Console.WriteLine("Bon après-midi");
            //else
            //    Console.WriteLine("Bonsoir");

            //Console.WriteLine(Environment.UserName);
            //Console.WriteLine("Press a key to exit");
            //Console.ReadKey();

        }
    }
}
