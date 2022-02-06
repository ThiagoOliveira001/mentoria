using System;

class Program {
    public static void Main(string[] args) {
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        int produto = n1 * n2;
        Console.WriteLine("PROD = {0}", produto);
    }
}