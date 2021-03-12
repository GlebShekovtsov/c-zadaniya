using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение X");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x>0)
            {
                Console.WriteLine(Math.Sin(x));
            }    
            else
            {
                Console.WriteLine(Math.Cos(x));
            }
            Console.ReadKey();
        }
    }
}
