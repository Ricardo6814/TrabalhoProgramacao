using System;
class Program
{
    static void Main()
    {
        // Calcular o que restara do salrio de João após pagar as contas
        // Solicitar o salário de João
        // Solicitar o valor das contas
        // multa de 2% sobre cada conta
        // Calcular o total das contas com a multa


        Console.WriteLine("Digite o salário de João: ");
        double salarioJoao = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor da conta 1: ");
        double conta1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor da conta 2: ");
        double conta2 = Convert.ToDouble(Console.ReadLine());

        // Calcular a multa de 2% sobre cada conta
        double multaConta1 = conta1 * 0.02;
        double multaConta2 = conta2 * 0.02;

        // Calcular o total das contas com a multa
        double totalContas = conta1 + multaConta1 + conta2 + multaConta2;

        // Calcular o que restará do salário de João após pagar as contas
        double salarioRestante = salarioJoao - totalContas;
        // Exibir os resultados
        Console.WriteLine("--- Controle de Salário de João ---");
        Console.WriteLine($"Salário de João: {salarioJoao:F2}");
        Console.WriteLine($"Valor da conta 1: {conta1:F2} (multa: {multaConta1:F2})");
        Console.WriteLine($"Valor da conta 2: {conta2:F2} (multa: {multaConta2:F2})");
        Console.WriteLine($"Total das contas com multas: {totalContas:F2}");
        Console.WriteLine($"Salário restante de João após pagar as contas: {salarioRestante:F2}");
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();

        // O programa calcula o que restará do salário de João após pagar as contas, incluindo uma multa de 2% sobre cada conta.
        // Ele solicita o salário de João e os valores das contas, calcula as multas, o total das contas e o salário restante.
        Console.ReadKey();

    }
}