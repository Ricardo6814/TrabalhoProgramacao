using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a sua altura (em metros):");
        double altura = Convert.ToDouble(Console.ReadLine()); // Lê a altura do usuário

        Console.WriteLine("Digite a distancia de você entre o predio;");
        double distancia  = Convert.ToDouble(Console.ReadLine()); // Lê o comprimento da sombra do usuário

        Console.WriteLine("Digite o angulo de elevação do sol (em graus):");
        double anguloElevacao = Convert.ToDouble(Console.ReadLine()); // Lê o ângulo de elevação do sol

        // Calcula a altura do prédio usando a tangente do ângulo
        double alturaPredio = altura + (distancia * Math.Tan(anguloElevacao * Math.PI / 180)); // Converte graus para radianos
        // Math.Tan calcula a tangente do ângulo
        // Math.PI é uma constante que representa o valor de pi (3.14159...)
        Console.WriteLine("--- Controle de Altura do Prédio ---");
        Console.WriteLine($"A altura do prédio é: {alturaPredio:F2} metros"); // F2 formata o número para duas casas decimais

      

        


    }
}