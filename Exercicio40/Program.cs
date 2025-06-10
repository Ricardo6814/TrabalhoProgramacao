using System;
class Program
{
    static void Main()
    {
        // Calcular o cateto da hipotenusa de um triângulo

        Console.WriteLine("Digite o valor do cateto oposto: ");
        double catetoOposto = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor do cateto adjacente: ");
        double catetoAdjacente = Convert.ToDouble(Console.ReadLine());

        double hipotenusa = Math.Sqrt(Math.Pow(catetoOposto, 2) + Math.Pow(catetoAdjacente, 2));
        // A hipotenusa é calculada pela fórmula: hipotenusa = √(catetoOposto² + catetoAdjacente²)
        // Math.Sqrt calcula a raiz quadrada e Math.Pow eleva um número a uma potência
        Console.WriteLine("--- Cálculo da Hipotenusa do Triângulo ---");
        Console.WriteLine($"A hipotenusa do triângulo com cateto oposto {catetoOposto} e cateto adjacente {catetoAdjacente} é: {hipotenusa:F2}");
        Console.WriteLine("Pressione qualquer tecla para sair...");
    }
}