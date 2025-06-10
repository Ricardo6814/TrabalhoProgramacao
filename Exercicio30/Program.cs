using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o salario do funcionário:");
        double salario = double.Parse(Console.ReadLine() ?? "0");
        //?? é usado para evitar NullReferenceException quando o usuário não digita nada

        Console.WriteLine("Digite a quantidade de vendas do funcionário:");
        int quantidadeVendas = int.Parse(Console.ReadLine() ?? "0");
        
        double aumento = 0.04; // 4% de aumento
        double novoSalario = salario + (quantidadeVendas * aumento);

        Console.WriteLine("--- Controle de Aumento Salarial ---");
        Console.WriteLine($"Salário atual: {salario:F2}");
        Console.WriteLine($"Quantidade de vendas: {quantidadeVendas}");
        Console.WriteLine($"Novo salário com aumento de 4%: {novoSalario:F2}");
        Console.WriteLine("Pressione qualquer tecla para sair...");

        
    }
}