using System;
class Program
    {
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de moedas de 1 centavo:");
        int quantidadeMoedas1Centavo = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 converte uma string para um número inteiro (int)

        Console.WriteLine("Digite a quantidade de moedas de 5 centavos:");
        int quantidadeMoedas5Centavos = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 converte uma string para um número inteiro (int)

        Console.WriteLine("Digite a quantidade de moedas de 10 centavos:");
        int quantidadeMoedas10Centavos = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 converte uma string para um número inteiro (int)

        Console.WriteLine("Digite a quantidade de moedas de 25 centavos:");
        int quantidadeMoedas25Centavos = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 converte uma string para um número inteiro (int)

        Console.WriteLine("Digite a quantidade de moedas de 50 centavos:");
        int quantidadeMoedas50Centavos = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 converte uma string para um número inteiro (int)

        Console.WriteLine("Digite a quantidade de moedas de 1 real:");
        int quantidadeMoedas1Real = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 converte uma string para um número inteiro (int)

        // Calcula o valor total em centavos
        double valorTotalCentavos = (quantidadeMoedas1Centavo * 1) +
                                    (quantidadeMoedas5Centavos * 5) +
                                    (quantidadeMoedas10Centavos * 10) +
                                    (quantidadeMoedas25Centavos * 25) +
                                    (quantidadeMoedas50Centavos * 50) +
                                    (quantidadeMoedas1Real * 100);

        // Converte o valor total para reais
        double valorTotalReais = valorTotalCentavos / 100.0; // Converte centavos para reais
        Console.WriteLine("--- Controle de Moedas ---");
        Console.WriteLine($"Quantidade de moedas de 1 centavo: {quantidadeMoedas1Centavo}");
        Console.WriteLine($"Quantidade de moedas de 5 centavos: {quantidadeMoedas5Centavos}");
        Console.WriteLine($"Quantidade de moedas de 10 centavos: {quantidadeMoedas10Centavos}");
        Console.WriteLine($"Quantidade de moedas de 25 centavos: {quantidadeMoedas25Centavos}");
        Console.WriteLine($"Quantidade de moedas de 50 centavos: {quantidadeMoedas50Centavos}");
        Console.WriteLine($"Quantidade de moedas de 1 real: {quantidadeMoedas1Real}");
        Console.WriteLine($"Valor total em centavos: {valorTotalCentavos} centavos");
        Console.WriteLine($"Valor total em reais: R$ {valorTotalReais:F2}"); // F2 formata o número para duas casas decimais
    }
}