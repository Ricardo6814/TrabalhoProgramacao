using System;   
class Program
    {
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de latinhas de refrigerante:");
        int quantidadeLatinhas = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 converte uma string para um número inteiro (int)

        Console.WriteLine("Digite a quantidade de garrafas:");
        int quantidadeGarrafas = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 converte uma string para um número inteiro (int)

        Console.WriteLine("Digite a quantidade de garrafões:");
        int quantidadeGarrafoes = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 converte uma string para um número inteiro (int)

        // Cada latinha tem 350 ml, cada garrafa tem 600 ml e cada garrafão tem 2 litros (2000 ml)

        double volumeTotal = (quantidadeLatinhas * 0.35) + (quantidadeGarrafas * 0.6) + (quantidadeGarrafoes * 2.0);

        // Calcula o volume total em litros
        double volumeTotalLitros = volumeTotal / 1000; // Converte mililitros para litros
        Console.WriteLine("--- Controle de Bebidas ---");
        Console.WriteLine($"Quantidade de latinhas: {quantidadeLatinhas}, quantidade de garrafas: {quantidadeGarrafas}, quantidade de garrafões: {quantidadeGarrafoes}.");
        Console.WriteLine($"Volume total de bebidas: {volumeTotal:F2} Litros");

    }
}