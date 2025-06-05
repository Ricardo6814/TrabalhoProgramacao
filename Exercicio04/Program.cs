using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());

        int dias = idade * 365;
        Console.WriteLine($"Olá {nome}, você já viveu aproximadamente {dias} dias.");
    }
}