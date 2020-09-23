
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа для НОД");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"НОД({x}, {y}) = {Nod(x, y)}");
            Console.WriteLine();


            Console.WriteLine("Введите числа для проверки на простоту");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine(IsSimple(s) ? "Простое" : "Составное");
            Console.WriteLine();


            Console.WriteLine("Введите интервал:");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            SimpleNumbersInInterval(m, n);
            Console.WriteLine();


            Console.WriteLine("Введите число для нахождения обратного");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите модуль");
            int module = int.Parse(Console.ReadLine());

            if (Nod(number, module) == 1)
            {
                InverseMod(number, module);
            }
            else
            {
                Console.WriteLine("НОД != 1");
            }
        }


        private static void SimpleNumbersInInterval(int m, int n)
        {
            int counter = 0;
            if (n < m)
            {
                Console.WriteLine("Неверный промежуток");
            }

            Console.Write($"Простые числа интервала [{m},{n}]: ");

            for (int i = m; i <= n; i++)
            {
                if (IsSimple(i))
                {
                    Console.Write(i.ToString() + " ");
                    counter++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Число простых чисел {counter}");
        }



        private static int Nod(int x, int y)
        {
            while (x != 0 && y != 0)
            {
                if (x > y)
                {
                    x -= y;
                }
                else
                {
                    y -= x;
                }
            }
            return Math.Max(x, y);
        }

        private static bool IsSimple(int x)
        {
            for (int i = 2; Math.Pow(i, 2) <= x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void InverseMod(int a, int m)
        {
            a = a % m;

            for (int x = 1; x < m; x++)
            {
                if ((a * x) % m == 1)
                {
                    Console.WriteLine($"Обратный элемент {a} по модулю {m} это {x}");
                }
            }
        }
    }
}
