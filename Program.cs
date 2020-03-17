using System;

namespace Lect5.Greating
{
    class Program
    {
        static void Main(string[] args)
        {

            TimeSpan time = DateTime.Now.TimeOfDay;
            int hours = time.Hours;
            Console.WriteLine(hours);
            if(hours > 9 && hours < 12)
            {
                Console.WriteLine("Good Morning, guys");
            }
            else if(hours > 12 && hours < 15)
            {
                Console.WriteLine("Good Day, guys");
            }
            else if(hours > 15 && hours < 22)
            {
                Console.WriteLine("Good Evening, guys");
            }
            else
            {
                Console.WriteLine("Bad Idea");
            }

        }
    }
}
