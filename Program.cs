using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество метров");
            int metr = Convert.ToInt32(Console.ReadLine());
            int kilo = metr / 1000;
            Console.WriteLine($" Это будет {kilo} километров");
            Console.ReadKey();
        }
    }
}
