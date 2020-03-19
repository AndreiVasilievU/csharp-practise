using System;

namespace Lect5_LetterA
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == 'a')
                {
                    count++;
                }
            }
            
            Console.WriteLine(count);
        }
    }
}
