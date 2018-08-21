using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Message
    {
        static public ITimeProvider TimeProvider { get; set; } = new TimeProvider();

        public int[] Intervals { get; set; } = { 9, 13, 18 };

        public string UserName { get; set; } = Environment.UserName;

        public DateTime Now { get { return TimeProvider.Now(); } }

        public bool WeekEnd
        {
            get
            {
                switch (Now.DayOfWeek)
                {
                    case DayOfWeek curDay when (curDay == DayOfWeek.Friday && Now.Hour >= Intervals[2]) || (curDay == DayOfWeek.Monday && Now.Hour < Intervals[1]):
                    case DayOfWeek.Saturday:
                    case DayOfWeek.Sunday:
                        return true;
                    default:
                        return false;
                }
            }
        }

        public string Greeting
        {
            get
            {
                if (WeekEnd)
                    return "Bon week-end";
                else
                    switch (Now.Hour)
                    {
                        case int hour when (hour >= Intervals[0] && hour < Intervals[1]):
                            return "Bonjour";
                        case int hour when (hour >= Intervals[1] && hour < Intervals[2]):
                            return "Bon après-midi";
                        default:
                            return "Bonsoir";
                    }
            }
        }

        public string GetHelloMessage()
        {
            return Greeting + ", " + UserName + " !";
        }

        public Message(int[] array)
        {
            Intervals = array;
        }

        public Message()
        {
        }
    }
}
