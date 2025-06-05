using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o x, o primeiro ponto :");
        double x1 = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite o y, o primeiro ponto :");
        double y1 = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite o x, o segundo ponto :");
        double x2 = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite o y, o segundo ponto :");
        double y2 = double.Parse(Console.ReadLine() ?? "0");

        // Fórmula da distância entre dois pontos (x1, y1) e (x2, y2)
        // Math.Sqrt calcula a raiz quadrada, Math.Pow calcula a potência
        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        // F2 mantém duas casas decimais
        Console.WriteLine($"A distância entre os pontos é: {distancia:F2}");

    }

}
