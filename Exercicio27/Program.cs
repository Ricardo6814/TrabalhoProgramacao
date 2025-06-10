using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double total = numero1 / numero2;

        Console.WriteLine("--- Cálculo da Divisão ---");
        Console.WriteLine($"A divisão dos números {numero1}, {numero2} é: {total}");
    }
}