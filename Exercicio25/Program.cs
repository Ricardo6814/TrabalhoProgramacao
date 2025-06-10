using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o raio da caixa d'água:");
        double raio = Convert.ToDouble(Console.ReadLine()); // Convert.ToDouble converte uma string para um número de ponto flutuante (double)

        Console.WriteLine("Digite a altura da caixa d'água:");
        double altura = Convert.ToDouble(Console.ReadLine());

        double volume = Math.PI * Math.Pow(raio, 2) * altura; // Volume da caixa d'água (V = π * r² * h)
        double volumeLitros = volume * 1000; // Converte o volume de cm³ para litros (1 litro = 1000 cm³)
        // Math.PI é uma constante que representa o valor de π (pi), aproximadamente 3.14159.

        Console.WriteLine("--- Controle de Volume da Caixa d'Água ---");
        Console.WriteLine($"Raio: {raio} cm, Altura: {altura} cm, Volume total: {volumeLitros:F2} litros.");

    }
}