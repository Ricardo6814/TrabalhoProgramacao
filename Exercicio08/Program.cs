using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a primeira nota do aluno:");
        double nota1 = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite a segunda nota do aluno:");
        double nota2 = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite a terceira nota do aluno:");
        double nota3 = double.Parse(Console.ReadLine() ?? "0");

        double media = (nota1 + nota2 + nota3) / 3;

        // F2 mantém duas casas decimais
        Console.WriteLine($"A média do aluno é: {media:F2}");

    }
}