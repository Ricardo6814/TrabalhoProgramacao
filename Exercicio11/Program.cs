using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de dias sem acidente:");
        int dias = Convert.ToInt32(Console.ReadLine());

        int anos = dias / 360;
        int resto = dias % 360;

        int meses = resto / 30;
        int diasRestantes = resto % 30;

        Console.WriteLine($"O tempo sem acidentes é de {anos} anos, {meses} meses e {diasRestantes} dias.");
    }
}
