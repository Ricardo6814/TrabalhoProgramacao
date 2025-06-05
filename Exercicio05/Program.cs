using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o preço da gasolina:");
        decimal precoLitro = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor que deseja abastecer:");
        decimal valorAbastecido = decimal.Parse(Console.ReadLine());

        decimal litrosAbastecidos = valorAbastecido / precoLitro;

        Console.WriteLine($"Você abasteceu {litrosAbastecidos:F2} litros de gasolina.");
    }
}