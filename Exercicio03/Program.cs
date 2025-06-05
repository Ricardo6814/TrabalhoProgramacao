using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidede de pães vendidos:");
        int paes = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidede de broas vendidas:");
        int broas = int.Parse(Console.ReadLine());

        decimal totalpaes = paes * 0.12m;
        decimal totalbroas = broas * 1.50m;

        decimal total = totalpaes + totalbroas;
        decimal poupanca = total * 0.10m;

        // F2 mantém duas casas decimais

        Console.WriteLine($"Total arrecadado: R$ {total:F2}");
        Console.WriteLine($"Valor a guardar na poupança: R$ {poupanca:F2}");
    }
}