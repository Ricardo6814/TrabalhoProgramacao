using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite quantidade de blusas:");
        int quantidadeBlusas = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 converte uma string para um número inteiro (int)

        int novelosLa = quantidadeBlusas * 3; // Cada blusa usa 3 novelos de lã

        
        Console.WriteLine("--- Controle de Produção de Blusas ---");
        Console.WriteLine($"Quantidade de blusas: {quantidadeBlusas}, quantidade de novelos de lã necessários: {novelosLa} novelos.");


    }
}
