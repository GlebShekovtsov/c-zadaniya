using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            int v = a*a*a;
            Console.WriteLine($"Площадь составляет {v} см в кубе");
            int s = 4 * a*a;
            Console.WriteLine($"Площадь боковой поверхности составляет {s} см в квадрате");
            Console.ReadKey();
        }
    }
}
