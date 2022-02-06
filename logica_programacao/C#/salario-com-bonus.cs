using System;

class Program {
    public static void Main(string[] args) {
        string vendedor = Console.ReadLine();
        double salario = Convert.ToDouble(Console.ReadLine());
        double vendas = Convert.ToDouble(Console.ReadLine());
        double total = salario + (vendas * 0.15);
        Console.WriteLine("TOTAL = R$ {0}", total.ToString("F2"));
    }
}