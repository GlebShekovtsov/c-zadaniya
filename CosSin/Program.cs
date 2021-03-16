using System;

namespace CosSin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите режим работы: 1.Операции с комплексными числами 2. Решить квадратное уравнение");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Введите комплексное число a: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите комплексное число b: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Что вы хотите найти: a.Длину радиуса вектора; b. Угол; c.Тригонометрическую форму числа;");
                    string selection = Console.ReadLine();
                    switch (selection)
                    {
                        case "a":
                            int g = Convert.ToInt32(Math.Sqrt(a * a + b * b));
                            Console.WriteLine($"Длина радиуса вектора равна: {g}");
                            return;
                        case "b":
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
                            return;
                        case "c":
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
                            return;
                    }
                    return;
                case 2:
                    Console.WriteLine("Введите число a");
                    double a1=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите число b");
                    double b1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите число c");
                    double c1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Введеное квадратное уравнение:({a1})x^2+({b1})x+({c1})");
                    Console.ReadKey();
                    double sqrt = (b1 * b1) - 4*a1 + c1;
                    Console.WriteLine($"Дискриминант равен:{sqrt}");
                    if (sqrt<0)
                    {
                        Console.WriteLine("Решений нет");
                    }
                    if (sqrt==0)
                    {
                        double x01 = -((b1)/(2*a1));
                        Console.WriteLine($"X1 равен {x01}");
                    }
                    if (sqrt>0)
                    {
                        double x1 = ((-b1 + Math.Sqrt(sqrt)) / (2 * a1));
                        double x2 = ((b1 + Math.Sqrt(sqrt)) / (2 * a1));
                        Console.WriteLine($"X1 = {x1}\nX2 = {x2}");
                    }
                    return;
                    




                  

            }
        }
    }
}


