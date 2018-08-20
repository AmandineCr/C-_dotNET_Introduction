using System;
using System.Collections.ObjectModel;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            DateTime localDate = DateTime.Now;
            Boolean morning = localDate.Hour >= 9 && localDate.Hour < 13;
            Boolean afternoon = localDate.Hour >= 13 && localDate.Hour <= 18;


            DayOfWeek today = localDate.DayOfWeek;
            Collection<DayOfWeek> daysOfWeekend = new Collection<DayOfWeek>
            {
                DayOfWeek.Saturday,
                DayOfWeek.Sunday
            };

            if (daysOfWeekend.Contains(today))
                Console.WriteLine("Bon weekend !");
            else
                if (morning)
                Console.WriteLine("Bonjour c'est le matin");
            else if (afternoon)
                Console.WriteLine("Bon après-midi");
            else
                Console.WriteLine("Bonsoir");

            Message message = new Message();

            Console.WriteLine(Environment.UserName);
            System.Console.Write(Message.helloMessage);


            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
