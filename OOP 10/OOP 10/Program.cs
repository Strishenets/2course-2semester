using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_10
{
    internal class Program
    {
       
        static int FindSecondPosNum(int[] array)
        {
            int countPositive = 0;
            int secondPositive = 0; 
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    countPositive++;
                    if (countPositive == 2)
                    {
                        secondPositive = array[i];
                        break; 
                    }
                }
            }
            return secondPositive; 
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть кількість елементів масиву:");
            int ArrSize = int.Parse(Console.ReadLine());
            int[] Z = new int[ArrSize];

            Random rand = new Random();
            for (int i = 0; i < ArrSize; i++)
            {
                Z[i] = rand.Next(-10, 10);
            }

            Console.WriteLine("Масив випадкових чисел:");
            for (int i = 0; i < ArrSize; i++)
            {
                Console.WriteLine(Z[i]);
            }
            
            int Sum;
            Sum = (FindSecondPosNum(Z) + Z[2]);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Другий додатній елемент масиву: "+ FindSecondPosNum(Z) + "\nТретій елемент масиву: " + Z[2]);
            Console.WriteLine("----------------------------");

            Console.WriteLine($"Сума другого додатного і третього елемента масиву: {Sum}\n\n" );
          



        }
    }
}

