using System;

namespace OOP_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double QuantityButter = 1.0, QuantitySourCream = 2.0, QuantityCream = 3.0;
            double PriceButter = 8.5, PriceSourCream = 2.4, PriceCream = 4.1;

            double SumButter = 1, SumSourCream = 1, SumCream = 1, TotalPrice = 1;
            SumButter = PriceButter * QuantityButter;
            SumSourCream = PriceSourCream * QuantitySourCream;
            SumCream = PriceCream * QuantityCream;

            TotalPrice = SumButter + SumSourCream + SumCream;
            Console.WriteLine($"Кошти, які потрібні для оплати за:\nМасло - {SumButter} грн\nСметана - {SumSourCream} грн\nВершки - {SumCream} грн\n\nЗагальна сума: {TotalPrice} грн\n\n");

        }
    }
}
