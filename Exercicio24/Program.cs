using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de Refresco que você deseja produzir (em litros):");
        double quantidadeSuco = Convert.ToDouble(Console.ReadLine()); // Convert.ToDouble converte uma string para um número de ponto flutuante (double)

        double quantidadeMaracuja = quantidadeSuco * 0.2; // Cada litro de suco usa 0.2 // litros de maracujá
        double quantidadeDeAgua = quantidadeSuco * 0.8; // Cada litro de suco usa 0.8 // litros de água

        Console.WriteLine("--- Controle de Produção de Refresco de Maracujá ---");
        Console.WriteLine($"Quantidade de suco: {quantidadeSuco} litros, quantidade de maracujá necessária: {quantidadeMaracuja:F2} litros, quantidade de água necessária: {quantidadeDeAgua:F2} litros.");
    }
}