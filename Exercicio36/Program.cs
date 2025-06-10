using System;
class Program
{
    static void Main()
    {
        // Calcular o salario minimo e o salario do funcionario

        Console.WriteLine("Digite o valor do salário mínimo: ");
        double salarioMinimo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor do salário do funcionário: ");
        double salarioFuncionario = Convert.ToDouble(Console.ReadLine());

        double quantidadeSalariosMinimos = salarioFuncionario / salarioMinimo;
        // A quantidade de salários mínimos é o salário do funcionário dividido pelo salário mínimo
        Console.WriteLine("--- Cálculo de Salários Mínimos ---");
        Console.WriteLine($"O salário mínimo é: {salarioMinimo:F2}");
        Console.WriteLine($"O salário do funcionário é: {salarioFuncionario:F2}");
        Console.WriteLine($"O funcionário recebe {quantidadeSalariosMinimos:F2} salários mínimos.");
        Console.WriteLine("Pressione qualquer tecla para sair...");
    }
}