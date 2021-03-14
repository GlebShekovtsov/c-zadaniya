using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сколько тебе лет?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{name}, твой возраст - {age} лет");
            Console.WriteLine($"{name}, какого ты пола? 1.Мужской; 2.Женский");
            int gender = Convert.ToInt32(Console.ReadLine());
            if (gender == 1)
            {
                Console.WriteLine("Твой любимый цвет - синий");
            }
            else
            {
                Console.WriteLine("Твой любимый цвет розовый");
            }
            Console.WriteLine("Какие у тебя увлечения: 1.Компьютерные игры;2.Стримы Глада Валакаса;3.Настольные игры; 4.Баскетбол;/n" +
                " 5.Автомобили;6.Рыбалка");
            int hobby = Convert.ToInt32(Console.ReadLine());
            if (hobby == 1)
            {
                Console.WriteLine($"Круто, {name}, я тоже играю в компьютерные игры");
            }
            else if (hobby == 2)
            {
                Console.WriteLine($"Ты пожилой {name}");
            }
            else if (hobby == 3)
            {
                Console.WriteLine($"Жаль что thac0 убпали после 3.5 ревизии днд");
            }
            else if (hobby == 4)
            {
                Console.WriteLine("Баскетбол ногой");
            }
            else if (hobby == 5)
            {
                Console.WriteLine($"Тебе нужно купить запчасти для Toyota AE86 Trueno и развозить тофу после полуночи, {name} ");
            }
            else if (hobby == 6)
            {
                Console.WriteLine($"Жду тебя в русской рыбалке 3, {name}");
            }
            Console.WriteLine($"Тебе нравится код, {name}, 1.Да;2.Нет");
            int solution = Convert.ToInt32(Console.ReadLine());
            if (solution == 1)
            {
                Console.WriteLine($"Ты молодец, {name}");
            }
            else if (solution == 2)
            {
                Environment.Exit(0);
            }
            Console.ReadKey();

        }
    }
}