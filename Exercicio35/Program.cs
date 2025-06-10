using System;
class Program
{
    static void Main()
    {
        // Calcular area de um losango

        Console.WriteLine("Digite o valor da diagonal maior do losango: ");
        double diagonalMaior = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite o valor da diagonal menor do losango: ");
        double diagonalMenor = double.Parse(Console.ReadLine() ?? "0");

        double areaLosango = (diagonalMaior * diagonalMenor) / 2;
        // A área de um losango é (diagonalMaior * diagonalMenor) / 2
        // F2 mantém duas casas decimais
        Console.WriteLine("--- Cálculo da Área do Losango ---");
        Console.WriteLine($"A área do losango com diagonal maior {diagonalMaior} e diagonal menor {diagonalMenor} é: {areaLosango:F2} m²");
        Console.WriteLine("Pressione qualquer tecla para sair...");
    }
}