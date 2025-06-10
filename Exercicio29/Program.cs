using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o valor do produto:");
        double valorProduto = double.Parse(Console.ReadLine() ?? "0");

        double valorDesconto = 0.10; // 10% de desconto
        double valorComDesconto = valorProduto - (valorProduto * valorDesconto);

        Console.WriteLine("--- Cálculo do Desconto ---");
        Console.WriteLine($"O valor do produto é: {valorProduto:F2}");
        Console.WriteLine($"O valor do desconto é: {valorProduto * valorDesconto:F2}");
        Console.WriteLine($"O valor do produto com desconto é: {valorComDesconto:F2}");
        Console.WriteLine("Pressione qualquer tecla para sair...");
    }
}

