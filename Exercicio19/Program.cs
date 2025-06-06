using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de frangos:");
        int quantidadeFrangos = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 converte uma string para um número inteiro (int)
        double precoChip = 4.50; // Preço do chip por frango
        double precoAlimento = 3.50; // Preço do chip de alimentação por frango

        double custoPorFrango = precoChip + (2 * precoAlimento); // Custo total por frango
        double custoTotal = quantidadeFrangos * custoPorFrango; // Custo total para todos os frangos

        Console.WriteLine("--- Controle de Marcação da FrangoTech  ---");
        Console.WriteLine($"Custo por frango: R$ {custoPorFrango:F2}");
        Console.WriteLine($"Custo total para {quantidadeFrangos} frangos: R$ {custoTotal:F2}");

    }
}
