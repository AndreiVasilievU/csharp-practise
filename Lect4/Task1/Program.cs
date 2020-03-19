using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            short num1 = 5;
            object o = num1;
            sbyte num2 = (sbyte)(short)o;
            Console.WriteLine(num2);
            Console.WriteLine(num2.GetType());
        }
    }
}
