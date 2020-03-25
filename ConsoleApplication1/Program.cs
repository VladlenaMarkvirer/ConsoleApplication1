using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void ElectronicWatch()
        {
            Console.Write("Введите количество минут от начала суток: ");
            string input = Console.ReadLine();
            int n;

            bool ok = Int32.TryParse(input, out n);

            if (ok)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                int minute = n % 60; //количество минут (от 0 до 59)
                int hours = n / 60 % 24; //количество часов (0 до 23)

                Console.WriteLine("{0:00}:{1:00}", hours, minute);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Произошла ошибка ввода!");
            }
            Console.ResetColor();
        }

        static void MinTwo()
        {
            Console.Write("Введите первое число: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int second = Convert.ToInt32(Console.ReadLine());

            if (first <= second)
                Console.WriteLine("Минимальное число - первое ({0})", first);
            else Console.WriteLine("Минимальное число - второе ({0})", second);
        }
        static void MinThree()
        {
            Console.Write("Введите первое число: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int third = Convert.ToInt32(Console.ReadLine());

            if (min <= second)
                if (min <= third)
                    Console.WriteLine("Минимальное число - первое ({0})", min);
                else
                {
                    min = third;
                    Console.WriteLine("Минимальное число - третье ({0})", third);
                }
            else
            {
                min = second;
                if (min <= third)
                    Console.WriteLine("Минимальное число - второе ({0})", second);
                else
                {
                    min = third;
                    Console.WriteLine("Минимальное число - третье ({0})", third);
                }
            }

            if (min <= second)
            {
                if (third <= min)
                    min = third;
            }
            else
            {
                min = second;
                if (third <= min)
                    min = third;
            }
            Console.WriteLine("Минимальное число = " + min);
        }

        static void Shahkmaty()
        {
            Console.Write("Введите координату строки первой клетки: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату столбца первой клетки: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату строки второй клетки: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату столбца второй клетки: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            string color1 = PointColor(x1, y1);
            string color2 = PointColor(x2, y2);

            Console.WriteLine("Совпадение цветов клеток: "+(color1==color2));
        }

        static string PointColor(int x, int y)
        {
            string color = "";

            if (x % 2 == 1 && y % 2 == 1)
                color = "белый";
            if (x % 2 == 0 && y % 2 == 1)
                color = "чёрный";
            if (x % 2 == 1 && y % 2 == 0)
                color = "чёрный";
            if (x % 2 == 0 && y % 2 == 0)
                color = "белый";

            return color;
        }

        static void Main(string[] args)
        {
            string menu = "";
            while (menu != "2")
            {
                Console.Clear();
                //Console.WriteLine("1. Выведем часы!");
                //Console.WriteLine("1. Минимальное из двух чисел");
                //Console.WriteLine("1. Минимальное из трёх чисел");
                Console.WriteLine("1. Соовпадение цветов клетки шахматной доски");
                Console.WriteLine("2. Выход");

                Console.Write("Выберите пункт меню: ");
                menu = Console.ReadLine();

                switch (menu)
                {
                    //case "1": ElectronicWatch(); break;
                    //case "1": MinTwo(); break;
                    //case "1": MinThree(); break;
                    case "1": Shahkmaty(); break;
                    case "2": Console.WriteLine("До скорого!"); break;
                    default: Console.WriteLine("Пункт меню выбран не верно!"); break;
                }
                Console.ReadLine();
            }

        }
    }
}
