using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o valor da conta : R$");
        double valorConta = double.Parse(Console.ReadLine());
        // douple.Parse converte uma string para um número de ponto flutuante (double)

        double valorBase = valorConta / 3;
        // A conta é dividida por 3 para calcular o valor que cada pessoa deve pagar

        // Carlos e Andre pagam a parte inteira (sem centavos)
        // (int) converte o valor para inteiro, descartando a parte decimal
        int valorCarlos = (int)valorBase;
        int valorAndre = (int)valorBase;

        // Felipe paga a parte decimal (os centavos)
        double valorFelipe = valorBase - valorCarlos + valorAndre;

        // O valor que Felipe paga é a diferença entre o valor total e a soma das partes pagas por Carlos e Andre
        // Isso garante que a conta seja dividida corretamente entre os três amigos, sem deixar restos
        // \n é usado para pular uma linha na saída do console
        // F2 formata o número para exibir duas casas decimais

        Console.WriteLine("\n--- Valor que cada um deve pagar ---");
        Console.WriteLine("Carlos deve pagar: R$ " + valorCarlos);
        Console.WriteLine("André deve pagar: R$ " + valorAndre);
        Console.WriteLine("Felipe deve pagar: R$ " + valorFelipe.ToString("F2"));
    }
}
