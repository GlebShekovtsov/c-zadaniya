using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Введите комплексное число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите комплексное число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Что вы хотите найти: 1.Длину радиуса вектора; 2. Угол; 3.Тригонаметрическую форму числа");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                int z = Convert.ToInt32(Math.Sqrt(a * a + b * b));
                Console.WriteLine($"Длина радиуса вектора равна: {z}");
            }
            if (choice == 2)
            {
                if (a > 0)
                {
                    int fi = Convert.ToInt32(Math.Atan(b / a));
                    Console.WriteLine($"Угол равен: {fi}");
                }
                else if (a < 0 && b > 0)
                {
                    int fi = Convert.ToInt32(Math.Atan(b / a) + Math.PI);
                    Console.WriteLine($"Угол равен: {fi}");
                }
                else if (a < 0 && b < 0)
                {
                    int fi = Convert.ToInt32(Math.Atan(b / a) - Math.PI);
                    Console.WriteLine($"Угол равен: {fi}");
                }
            }
            if (choice == 3)
            {
                if (a > 0)
                {
                    int fi = Convert.ToInt32(Math.Atan(b / a));
                    int z = Convert.ToInt32(Math.Sqrt(a * a + b * b));
                    Console.WriteLine($"Тригонометрическая форма: {z}(cos{fi}+isin{fi})");
                }
                else if (a < 0 && b > 0)
                {
                    int fi = Convert.ToInt32(Math.Atan(b / a) + Math.PI);
                    int z = Convert.ToInt32(Math.Sqrt(a * a + b * b));
                    Console.WriteLine($"Тригонометрическая форма: {z}(cos{fi}+isin{fi})");
                }
                else if (a < 0 && b < 0)
                {
                    int fi = Convert.ToInt32(Math.Atan(b / a) - Math.PI);
                    int z = Convert.ToInt32(Math.Sqrt(a * a + b * b));
                    Console.WriteLine($"Тригонометрическая форма: {z}(cos{fi}+isin{fi})");
                }
            }
            Console.ReadKey();
        }
    }
}