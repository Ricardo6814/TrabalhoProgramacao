using System;
class Program
{
    static void Main()
    {
       // Fazer uma tabuada de um numero digitado pelo usuário
        Console.WriteLine("Digite um número para ver sua tabuada:");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("--- Tabuada do " + numero + " ---");
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        // Console.ReadKey é usado para esperar que o usuário pressione uma tecla antes de fechar o console
        Console.ReadKey();

    }
}
