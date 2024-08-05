using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_13
{
    abstract class Transport 
    {
        public string Name { get; set; }
        public double CostPerKm { get; set; }
        public double Distance { get; set; }

        public Transport()
        {
            Name = "Дані відсутні";
            CostPerKm = 0;
            Distance = 0;
        }

        public Transport(string name, double CostPerKm, double Distance)
        {
            this.Name = name;
            this.CostPerKm = CostPerKm;
            this.Distance = Distance;
        }

        public abstract void PrintInfo();

        public abstract double CalculateRouteCost();

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Transport other = (Transport)obj;
            return Name == other.Name && CostPerKm == other.CostPerKm && Distance == other.Distance;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ CostPerKm.GetHashCode() ^ Distance.GetHashCode();
        }
    }

    class Bus : Transport
    {
        public int Capacity { get; set; }
        public Bus(string Name, double CostPerKm, double Distance, int Capacity) : base(Name, CostPerKm, Distance)
        {
            this.Capacity = Capacity;
        }

        public Bus() : base()
        {
            this.Capacity = 0;
        }

        public  double CalculateRouteCost()
        {
            return CostPerKm * Distance;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Назва транспортного засобу: {Name}\nДистанція: {Distance} км\nЦіна поїздки за км: {CostPerKm} грн/км\nМаксимальна кількість місць: {Capacity}\n\nЗагальна вартість за поїздку: {CalculateRouteCost()} грн");

            Console.WriteLine("----------------------------------------------------------");
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Bus other = (Bus)obj;
            return base.Equals(obj) && Capacity == other.Capacity;
        }

    }

    class Train : Transport
    {
        public int NumTrain { get; set; }
        public Train() : base()
        {
            this.NumTrain = 0;
        }
        public Train(string Name, double CostPerKm, double Distance, int NumTrain) : base(Name, CostPerKm, Distance)
        {
            this.NumTrain = NumTrain;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Назва транспортного засобу: {Name}\nДистанція: {Distance} км\nЦіна поїздки за км: {CostPerKm} грн/км\nНомер вагону: {NumTrain}\n\nЗагальна вартість квитка: {CalculateRouteCost()} грн");
            Console.WriteLine("----------------------------------------------------------");
        }

        public override double CalculateRouteCost()
        {
            return CostPerKm * Distance;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Train other = (Train)obj;
            return base.Equals(obj) && NumTrain == other.NumTrain;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Transport bus1 = new Bus("Автобус", 3, 6, 50);
            Transport bus2 = new Bus("Автобус", 3, 6, 50);
            Transport train1 = new Train("Потяг", 8, 10, 4);
            Transport train2 = new Train("Потяг", 10, 35, 4);
            bus1.PrintInfo();
            train1.PrintInfo();
            bus2.PrintInfo();
            train2.PrintInfo();


            Console.WriteLine("Чи рівні перший та другий автобуси: " + bus1.Equals(bus2)); 
            Console.WriteLine("Чи рівні перший та другий потяги: " + train1.Equals(train2));
            Console.WriteLine("----------------------------------------------------------\n");
        }
    }
}