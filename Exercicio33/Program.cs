using System;
class Program
{
    static void Main()
    {
     // Calcular a área de um trapézio 

     Console.WriteLine("Digite a base maior do trapézio: ");
        double baseMaior = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite a base menor do trapézio: ");
        double baseMenor = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite a altura do trapézio: ");
        double altura = double.Parse(Console.ReadLine() ?? "0");

        double areaTrapezio = ((baseMaior + baseMenor) * altura) / 2;
        // ((baseMaior + baseMenor) * altura) / 2 é a fórmula para calcular a área do trapézio
        // F2 mantém duas casas decimais

        Console.WriteLine("--- Cálculo da Área do Trapézio ---");
        Console.WriteLine($"A área do trapézio é: {areaTrapezio:F2} m²");
        Console.WriteLine("Pressione qualquer tecla para sair...");
    }
}