using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц:1.Январь 2.Февраль 3.Март 4.Апрель 5.Май 6.Июнь\n7.Июль 8.Август 9.Сентябрь 10.Октябрь 11.Ноябрь 12.Декабрь");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день");
            int n = Convert.ToInt32(Console.ReadLine());
            switch(m)
            {
                case 1:
                    if (n > 31)
                    {
                        Console.WriteLine("Введите корректное значение");
                        return;
                    }
                    else
                    {
                        n--;
                        Console.WriteLine($"Предыдущая дата:{n}.{m}.{g}");
                        n++;
                        Console.ReadKey();
                        Console.WriteLine($"Следующая дата:{n}.{m}.{g}");
                    }
                    return;
                case 2:
                    if (n > 28)
                    {
                        Console.WriteLine("Введите корректное значение");
                    }
                    else if (g % 4 == 0 && n < 29)
                    {
                        n--;
                        Console.WriteLine($"Предыдущая дата:{n}.{m}.{g}");
                        n++;
                        Console.WriteLine($"Следующая дата:{n}.{m}.{g}");

                    }
                    else if (n < 28)
                    {
                        n--;
                        Console.WriteLine($"Предыдущая дата:{n}.{m}.{g}");
                        n++;
                        Console.WriteLine($"Следующая дата:{n}.{m}.{g}");
                    }
                    return;
                case 3:
                    if (n>31)
                    {
                        Console.WriteLine("Введите корректное значение");
                        return;
                    }
                    else if (n < 31)
                    {
                        n--;
                        Console.WriteLine($"Предыдущая дата:{n}.{m}.{g}");
                        n++;
                        Console.WriteLine($"Следующая дата:{n}.{m}.{g}");
                    }
                    return;
                case 4:
                    if (n > 30)
                    {
                        Console.WriteLine("Введите корректное значение");
                        return;
                    }
                    else if (n < 30)
                    {
                        n--;
                        Console.WriteLine($"Предыдущая дата:{n}.{m}.{g}");
                        n++;
                        Console.WriteLine($"Следующая дата:{n}.{m}.{g}");
                    }
                    return;
                case 5:
                    if (n>31)
                    {
                        Console.WriteLine("Введите корректное значение");
                        return;
                    }
                    if (n < 31)
                    {
                        n--;
                        Console.WriteLine($"Предыдущая дата:{n}.{m}.{g}");
                        n++;
                        Console.WriteLine($"Следующая дата:{n}.{m}.{g}");
                    }
                    return;
                case 6:
                    if (n>30)
                    {
                        Console.WriteLine("Введите корректное значение");
                        return;
                    }
                    if (n < 30)
                    {
                        n--;
                        Console.WriteLine($"Предыдущая дата:{n}.{m}.{g}");
                        n++;
                        Console.WriteLine($"Следующая дата:{n}.{m}.{g}");
                    }
                    return;
                case 7:
                    if (n>31)
                    {
                        Console.WriteLine("Введите корректное значение");
                        return;
                    }
                    if (n < 31)
                    {
                        n--;
                        Console.WriteLine($"Предыдущая дата:{n}.{m}.{g}");
                        n++;
                        Console.WriteLine($"Следующая дата:{n}.{m}.{g}");
                    }
                    return;
                case 8:
                    if (n > 31)
                    {
                        Console.WriteLine("Введите корректное значение");
                        return;
                    }
                    if (n < 31)
                    {
                        n--;
                        Console.WriteLine($"Предыдущая дата:{n}.{m}.{g}");
                        n++;
                        Console.WriteLine($"Следующая дата:{n}.{m}.{g}");
                    }
                    return;
                case 9:
                    if (n > 30)
                    {
                        Console.WriteLine("Введите корректное значение");
                        return;
                    }
                    if (n < 30)
                    {
                        n--;
                        Console.WriteLine($"Предыдущая дата:{n}.{m}.{g}");
                        n++;
                        Console.WriteLine($"Следующая дата:{n}.{m}.{g}");
                    }
                    return;
                case 10:
                    if (n>31)
                    {
                        Console.WriteLine("Введите корректное значение");
                        return;
                    }
                    if (n < 31)
                    {
                        n--;
                        Console.WriteLine($"Предыдущая дата:{n}.{m}.{g}");
                        n++;
                        Console.WriteLine($"Следующая дата:{n}.{m}.{g}");
                    }
                    return;
                case 11:
                    if (n>30)
                    {
                        Console.WriteLine("Введите корректное значение");
                        return;
                    }
                    if (n < 30)
                    {
                        n--;
                        Console.WriteLine($"Предыдущая дата:{n}.{m}.{g}");
                        n++;
                        Console.WriteLine($"Следующая дата:{n}.{m}.{g}");
                    }
                    return;
                case 12:
                    if (n>31)
                    {
                        Console.WriteLine("Введите корректное значение");
                        return;
                    }
                    if(n<31)
                    {
                    n--;
                    Console.WriteLine($"Предыдущая дата:{n}.{m}.{g}");
                    n++;
                    Console.WriteLine($"Следующая дата:{n}.{m}.{g}");
                    }
                   return;
            }
            return;
        }
    }
}
