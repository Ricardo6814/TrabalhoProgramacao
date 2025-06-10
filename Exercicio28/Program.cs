using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a primeira nota do aluno:");
        double nota1 = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite a segunda nota do aluno:");
        double nota2 = double.Parse(Console.ReadLine() ?? "0");

        double mediaponderada = (nota1 * 2 + nota2 * 3) / 5;
        // F2 mantém duas casas decimais
        Console.WriteLine($"A média ponderada do aluno é: {mediaponderada:F2}");

    }
}
