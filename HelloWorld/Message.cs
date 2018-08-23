using HelloWorldTests;
using System;
using System.Collections.ObjectModel;

namespace HelloWorld
{


    public class Message
    {
        public IDateTimeProvider DateTimeProvider = new RealDateTime(); 
        DateTime LocalDate => DateTimeProvider.Date;

        public INameProvider NameProvider = new RealName();
        string myName => NameProvider.Name;

        int morningStart;
        int afternoonStart;
        int eveningStart;


        Boolean Morning
        {
            get
            {
                return LocalDate.Hour >= morningStart && LocalDate.Hour < afternoonStart;
            }
        }

        Boolean Afternoon
        {
            get
            {
                return LocalDate.Hour >= afternoonStart && LocalDate.Hour < eveningStart;
            }
        }

        DayOfWeek Today
        {
            get
            {
                return LocalDate.DayOfWeek;
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
                    return "Bonjour";
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


