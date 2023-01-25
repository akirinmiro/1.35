using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первый катет");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второй катет");
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Math.Sqrt(a * a + b * b);
        Console.WriteLine("Гипотенуза: {0}", c);
    }
}

