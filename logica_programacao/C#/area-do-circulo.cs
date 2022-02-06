using System;

class Program {
    public static void Main(string[] args) {
        double n = 3.14159;
        double raio = Convert.ToDouble(Console.ReadLine());
        double area = n*Math.Pow(raio, 2);
        Console.WriteLine("A={0}", area.ToString("F4"));
    }
}