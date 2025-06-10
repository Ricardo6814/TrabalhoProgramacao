using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número:");
        double numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número:");
        double numero3 = Convert.ToInt32(Console.ReadLine());

        double total = numero1 * numero2 * numero3;

        Console.WriteLine("--- Cálculo do Produto ---");
        Console.WriteLine($"O produto dos números {numero1}, {numero2} e {numero3} é: {total}");


    }
}
