using System;
using System.Text;

class NormalizedVector
{
    private double x, y;

    public NormalizedVector()
    {
        this.x = 1.0;
        this.y = 0;
    }
    public NormalizedVector(double x, double y)
    {
        double mod = Math.Sqrt(x * x + y * y);
        if (mod != 0)
        {
            this.x = x / mod;
            this.y = y / mod;
        }
        else
        {
            this.x = 1.0;
            this.y = 0.0;
        }
    }

    public double X
    {
        get { return this.x; }
        set { this.x = value; }
    }
    public double Y
    {
        get { return this.y; }
        set { this.y = value; }
    }

    public override string ToString()
    {
        return $"X = {x:F2}\nY = {y:F2}";
    }

    public static double operator *(NormalizedVector v1, NormalizedVector v2)
    {
        return v1.x * v2.x + v1.y * v2.y;
    }

    public static NormalizedVector operator *(NormalizedVector v,  double scalar) 
    {
        return new NormalizedVector(v.X * scalar, v.Y * scalar);
    }

    public override bool Equals(object obj)
    {
        if(obj is null)
            return false;
        
        NormalizedVector other = (NormalizedVector) obj;
        return this.x == other.x && this.y == other.y;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        double x, y;
        Console.WriteLine("Введіть координати для X: ");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть координати для Y: ");
        y = double.Parse(Console.ReadLine());
        Console.WriteLine("--------------------------------------------------------");

        NormalizedVector v1 = new NormalizedVector(x, y);
        NormalizedVector v2 = new NormalizedVector();

        Console.WriteLine("Перший вектор: \n" + v1);
        Console.WriteLine("Другий вектор: \n" + v2);
        Console.WriteLine("--------------------------------------------------------");

        double scalarProduct = v1 * v2;
        Console.WriteLine($"Скалярний добуток першого та другого векторів:  {scalarProduct:F2}");

        double scalar = 0.2;
        NormalizedVector scaledVector = v1 * scalar;
        Console.WriteLine("Третій вектор, створений шляхом множення першого вектору на скаляр: " + scalar + $":  \n{scaledVector}");


        Console.WriteLine("Перевірка на рівність першого та другого векторів: " + v1.Equals(v2));
        Console.ReadKey();
    }
}

