{
    static void Main()
    {
        double precoP = 10;
        double precoM = 12;
        double precoG = 15;

        Console.WriteLine("Digite a quantidade de camisetas P");
        int quantidadeP = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de camisetas M");
        int quantidadeM = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de camisetas G");
        int quantidadeG = int.Parse(Console.ReadLine());

        double totalP = quantidadeP * precoP;
        double totalM = quantidadeM * precoM;
        double totalG = quantidadeG * precoG;

        double totalVendas = totalP + totalM + totalG;

        // {totalVendas:F2} mantém duas casas decimais

        Console.WriteLine($"Total arrecadado com as vendas: R$ {totalVendas:F2}");




    }
}