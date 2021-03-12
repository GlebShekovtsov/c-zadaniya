using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение стороны a");
            int a = Convert.ToInt32(Console.ReadLine());
            int p = 4 * a;
            Console.WriteLine($"Периметр равен {p} ");
            Console.ReadKey();
        }
    }
}
