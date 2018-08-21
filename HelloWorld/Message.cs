using System;
using System.Collections.ObjectModel;

namespace HelloWorld
{


    public class Message
    {
        DateTime localDate = DateTime.Now;
        string myName = Environment.UserName;
        int morningStart;
        int afternoonStart;
        int eveningStart;


        Boolean Morning
        {
            get
            {
                return localDate.Hour >= morningStart && localDate.Hour < afternoonStart;
            }
        }

        Boolean Afternoon
        {
            get
            {
                return localDate.Hour >= afternoonStart && localDate.Hour < eveningStart;
            }
        }

        DayOfWeek Today
        {
            get
            {
                return localDate.DayOfWeek;
            }
        }

        Collection<DayOfWeek> daysOfWeekend = new Collection<DayOfWeek>
        {
            DayOfWeek.Saturday,
            DayOfWeek.Sunday
        };

        public string GetHelloMessage()
        {
            return Greeting + ' ' + myName;
        }

        string Greeting
        {
            get
            {
                if (daysOfWeekend.Contains(Today))
                    return "Bon weekend !";
                else
                    if (Morning)
                    return "Bonjour c'est le matin";
                else if (Afternoon)
                    return "Bon après-midi";
                else
                    return "Bonsoir";
            }
        }

        // Propriété
        public string Msg
        { get; set; }

        public Message(int morning = 8, int afternoon = 13, int evening = 18)
        {
            morningStart = morning;
            afternoonStart = afternoon;
            eveningStart = evening;
        }
    }
}


