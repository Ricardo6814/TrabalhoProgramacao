using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de horas trabalhadas:");
        int horasNormais = Convert.ToInt32(Console.ReadLine());// Convert.ToInt32 converte uma string para um número inteiro (int)

        Console.WriteLine("Digite a quantidade de horas extras trabalhadas:");
        int horasExtras = Convert.ToInt32(Console.ReadLine());

        double salarioBruto = (horasNormais * 10) + (horasExtras * 15);

        double desconto = salarioBruto * 0.1; // 10% de desconto
        double salarioLiquido = salarioBruto - desconto;

        Console.WriteLine("--- Salário ---");
        Console.WriteLine($"Salário bruto: R$ {salarioBruto:F2}");
        Console.WriteLine($"Desconto (10%): R$ {desconto:F2}");
        Console.WriteLine($"Salário líquido: R$ {salarioLiquido:F2}");

    }
}
