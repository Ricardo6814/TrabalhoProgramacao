using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o salario ataual do funcionario:");
        decimal salarioAtual = decimal.Parse(Console.ReadLine());

        decimal aumento = salarioAtual + (salarioAtual * 0.15m); // 15% de aumento
        decimal novoSalario = aumento - (aumento * 0.08m); // 8% de desconto

        // \n serve para representar um caractere de quebra de linha, indicando que o texto deve mudar para a linha seguinte.
        Console.WriteLine("\n--- Resultado ---");
        Console.WriteLine("Salário inicial: R$" + salarioAtual.ToString("F2"));
        Console.WriteLine("Salário com aumento: R$" + aumento.ToString("F2"));
        Console.WriteLine("Salário final após impostos: R$" + novoSalario.ToString("F2"));
    }
}