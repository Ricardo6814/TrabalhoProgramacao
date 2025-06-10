using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de cavalos:");
        int quantidadeCavalos = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 converte uma string para um número inteiro (int)

       int ferradurasNecessarias = quantidadeCavalos * 4; // Cada cavalo precisa de 4 ferraduras

        Console.WriteLine("--- Controle de Ferraduras ---");
        Console.WriteLine($"Quantidade de cavalos: {quantidadeCavalos}, quantidade de ferraduras necessárias: {ferradurasNecessarias} ferraduras.");
    }
}