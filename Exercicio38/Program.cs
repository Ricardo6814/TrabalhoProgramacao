using System;
class Program
{
    static void Main()
    {
        // Calcular a idade de uma pessoa em dias, semanas, meses e anos

        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());

        int dias = idade * 365; // Aproximadamente 365 dias por ano
        int semanas = idade * 52; // Aproximadamente 52 semanas por ano
        int meses = idade * 12; // Aproximadamente 12 meses por ano
        int anos = idade; // A idade já está em anos
        Console.WriteLine("--- Cálculo da Idade ---");
        Console.WriteLine($"Olá {nome}, você já viveu aproximadamente:");
        Console.WriteLine($"{dias} dias");
        Console.WriteLine($"{semanas} semanas");
        Console.WriteLine($"{meses} meses");
        Console.WriteLine($"{anos} anos");
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey(); // Espera o usuário pressionar uma tecla antes de sair
    }
}
