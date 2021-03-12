using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            int x = Convert.ToInt32(Console.ReadLine());
            int equation = 7 * x * x + 3 * x + 6;
            Console.WriteLine($"X равен {equation}");
            Console.ReadKey();
        }
    }
}
