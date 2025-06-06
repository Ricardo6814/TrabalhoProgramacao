using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de sanduíches a fazer :");
        int quantidade = int.Parse(Console.ReadLine());
        // int.Parse converte uma string para um número inteiro (int)

        // Cálculos em gramas
        // 2 fatias de queijo de 50 gramas cada
        // 1 fatias de presunto de 50 gramas cada
        // 1 rodela de 100g
        int queijoGramas = quantidade * 2 * 50;
        int presuntoGramas = quantidade * 2 * 50;
        int carneGramas = quantidade * 100;

        // Conversão de gramas para quilos
        // Divisão por 1000 para converter gramas em quilos
        double queijoKg = queijoGramas / 1000.0;
        double presuntoKg = presuntoGramas / 1000.0;
        double carneKg = carneGramas / 1000.0;

        // F3 formata o número para exibir três casas decimais

        Console.WriteLine("\n--- Ingredientes necessários (em quilos) ---");
        Console.WriteLine("Queijo: " + queijoKg.ToString("F3") + " kg");
        Console.WriteLine("Presunto: " + presuntoKg.ToString("F3") + " kg");
        Console.WriteLine("Carne: " + carneKg.ToString("F3") + " kg");

    }
}