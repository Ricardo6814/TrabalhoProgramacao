using System;
class Program
{
    static void Main()
    {
        int[] diasPorMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        Console.WriteLine("Digite o número do mês (1 a 12):");
        int mes = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o dia");
        int dia = int.Parse(Console.ReadLine());

        int totalDias = 0;
        for (int i = 0; i < mes - 1; i++)
        {
            totalDias += diasPorMes[i];
        }

        totalDias += dia;
        Console.WriteLine($"Já se passaram {totalDias} dias desde o início do ano até {dia}/{mes}.");
    }
}