using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o peso do prato de comida (em kg):");
        decimal pesoPrato = decimal.Parse(Console.ReadLine());

        decimal valor = pesoPrato * 12.00m; // R$ 12,00 por kg

        Console.WriteLine($"O valor a pagar pelo prato é: R$ {valor:F2}");

    }
}
