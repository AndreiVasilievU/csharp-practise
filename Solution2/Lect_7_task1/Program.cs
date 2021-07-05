using System;

namespace Lect_7_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task3(); 
        }
        static void Task1()
        {
            int[,,] array1 = new int[2,2,3];
        }
        static void Task2()
        {
            
        }
        static void Task3()
        {
            Random rnd = new Random();
            int[] mas = new int[13];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(50);
            }
            for (int k = 0; k < mas.Length; k++)
            {
                for (int j = 0; j < mas.Length - k-1 ; j++)
                {
                
                    if (mas[j] < mas[j + 1])
                    {
                        int temp = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = temp;
                    }
                }
            }
            foreach (int item in mas)
            {
                Console.WriteLine(mas[item]);
            }
            Console.WriteLine(mas[0]);
        }
    }
}
