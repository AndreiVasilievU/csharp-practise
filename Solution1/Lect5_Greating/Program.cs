using System;

namespace Lect5_Greating
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan time = DateTime.Now.TimeOfDay;
            if(time.Hours > 8 && time.Hours < 12)
            {
                Console.WriteLine(" Good Morning, guys");
            }
            else if (time.Hours > 11 && time.Hours < 15)
            {
                Console.WriteLine(" Good Day, guys");
            }
            else if (time.Hours > 14 && time.Hours < 22)
            {
                Console.WriteLine(" Good Evening, guys");
            }
            else
            {
                Console.WriteLine("Bad Idea");
            }
        }
    }
}
