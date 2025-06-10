using System;
class Program
{
    static void Main()
    {
        // Calcular a area de um quadrado
        Console.WriteLine("Digite o valor do lado do quadrado: ");
        double lado = Convert.ToDouble(Console.ReadLine());
        double area = lado * lado; // A área de um quadrado é lado * lado
        Console.WriteLine("--- Cálculo da Área do Quadrado ---");
        Console.WriteLine($"A área do quadrado com lado {lado} é: {area:F2} m²");
        Console.WriteLine("Pressione qualquer tecla para sair...");
    }
}