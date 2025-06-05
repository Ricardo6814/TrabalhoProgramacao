using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro de 3 dígitos:");
        int numero = Convert.ToInt32(Console.ReadLine());

        int centenas = numero / 100; // Extrai as centenas
        int dezenas = (numero / 10) % 10; // Extrai as dezenas
        int unidades = numero % 10; // Extrai as unidades

        Console.WriteLine("--- Resultado ---");
        Console.WriteLine($"Centenas: {centenas}");
        Console.WriteLine($"Dezenas: {dezenas}");
        Console.WriteLine($"Unidades: {unidades}");

    }
}