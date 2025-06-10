using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite seu peso (em kg):");
        double peso = double.Parse(Console.ReadLine() ?? "0");
        // ?? é o operador de coalescência nula, que garante que se a entrada for nula, use 0 como padrão.

        double  pesoAcimaDoPesoIdeal = peso + (peso * 0.15); // 15% acima do peso ideal
        double pesoAbaixoDoPesoIdeal = peso - (peso * 0.20); // 20% abaixo do peso ideal

        Console.WriteLine("--- Cálculo do Peso Ideal ---");
        Console.WriteLine($"Seu peso ideal é: {peso:F2} kg");
        Console.WriteLine($"Peso ideal 15% acima: {pesoAcimaDoPesoIdeal:F2} kg");
        Console.WriteLine($"Peso ideal 20% abaixo: {pesoAbaixoDoPesoIdeal:F2} kg");
        Console.WriteLine("Pressione qualquer tecla para sair...");



    }
}