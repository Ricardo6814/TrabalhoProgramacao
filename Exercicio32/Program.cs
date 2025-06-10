using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite seu peso (em kg):");
        double peso = double.Parse(Console.ReadLine() ?? "0");
        // ?? é o operador de coalescência nula, que garante que se a entrada for nula, use 0 como padrão.

        // Conversão de peso para gramas
        double pesoEmGramas = peso * 1000; // 1 kg = 1000 gramas

        Console.WriteLine("--- Conversão de Peso ---");
        Console.WriteLine($"Seu peso em gramas é: {pesoEmGramas:F2} g");
        Console.WriteLine("Pressione qualquer tecla para sair...");
    }
}