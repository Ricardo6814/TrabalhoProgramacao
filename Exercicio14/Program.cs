using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o raio da pizza (em cm):");
        double raio = double.Parse(Console.ReadLine());

        // valor pi é uma constante que representa a relação entre a circunferência de um círculo e seu diâmetro, aproximadamente 3.14159

        double pi = Math.PI; // ou você pode usar 3.14 se preferir
        // Math.PI é uma propriedade da classe Math que retorna o valor de pi com alta precisão.
        // Math.Pow é um método da classe Math que eleva um número a uma potência especificada.
        // Fórmula da área do círculo: A = π * r²
        double area = pi * Math.Pow(raio, 2);

        // F2 formata o número para exibir duas casas decimais
        Console.WriteLine($"A área da pizza é: {area:F2} cm²");

    }
}