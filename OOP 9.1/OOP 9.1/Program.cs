using System;
using System.Text;

namespace OOP_9._1
{
    internal class Program
    {
        static void PrintRange(double num, double rez)
        {
            if (num < -10)
            {
                Console.WriteLine("x потрапляє в діапазон 'менше за -10' ");
            }
            else if (num < -1)
            {
                Console.WriteLine("x потрапляє в діапазон 'менше за -1' ");
            }
            else if (num > 10)
            {
                Console.WriteLine("x потрапляє в діапазон 'більше за 10' ");
            }
            else if (num > 1)
            {
                Console.WriteLine("x потрапляє в діапазон 'більше за 1' ");
            }

            if (rez >= 0)
            {
                Console.WriteLine("Результат потрапляє в діапазон 'позитивних'");
            }
            else
            {
                Console.WriteLine("Результат потрапляє в діапазон 'негативних'");
            }
            
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double x, y, z, a;

            Console.WriteLine("Для завершення роботи програми введіть x = 0\n");
            do
            {
                Console.WriteLine("Введіть значення x");
                x = double.Parse(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("Роботу програми завершено\n");
                    break;
                }

                Console.WriteLine("Введіть значення y");
                y = double.Parse(Console.ReadLine());
                Console.WriteLine("Введіть значення z");
                z = double.Parse(Console.ReadLine());
                if (x > 0)
                {
                    a = Math.Sqrt(Math.Pow(x, 3) + Math.Pow(y, 2) + z);
                    Console.WriteLine("Результат обчислення: " + Math.Round(a));
                    PrintRange(x, a);
                    Console.WriteLine("-----------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("За даними умовами приклад не може бути обрахований, квадратний корінь з від'ємних чисел не може бути обрахований\nВираз під коренем: " + (Math.Pow(x, 3) + Math.Pow(y, 2) + z));
                    Console.WriteLine("-----------------------------------------------------------");
                }
               

            } while (x != 0);
        }
    }
}
