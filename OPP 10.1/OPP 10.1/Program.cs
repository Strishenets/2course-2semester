using System;
using System.Text;


namespace OPP_10._1
{
    internal class Program
    {
        static int MinIndex(int[] array)
        {
            int IndexMin = 0;
            for(int i = 0; i < array.Length; i++) 
            {
                if (array[i] < array[IndexMin])
                {
                    IndexMin = i;
                }
            }
            return IndexMin;
        }
        static int MaxIndex(int[] array)
        {
            int IndexMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[IndexMax])
                {
                    IndexMax = i;
                }
            }
            return IndexMax;
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

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Індекс мінімального члена масиву: " + MinIndex(Z));
            Console.WriteLine("Індекс максимального члена масиву: " + MaxIndex(Z));
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Добуток максимального та мінімального індексів масиву: " + MinIndex(Z) * MaxIndex(Z) + "\n\n");
        }
    }
}
