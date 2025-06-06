using System;
class Program
{
    static void Main()
    {
        // Fahrenheit = (Celsius × 9/5) + 32
        // Convert.ToDouble converte uma string para um número de ponto flutuante (double)
        Console.WriteLine("Digite a temperautura em graus Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Calculo da conversão de Celsius para Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        // F2 formata o número para exibir duas casas decimais
        // ToString("F2") converte o número para uma string com duas casas decimais
        Console.WriteLine("A temperatura em graus Fahrenheit é: " + fahrenheit.ToString("F2") + "°F");


    }
}
