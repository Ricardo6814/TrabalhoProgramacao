decimal area, tamanho, largura;

Console.WriteLine("Informe o tamanho do terreno em metros");
tamanho = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Informe a largura do terreno em metros");
largura = Convert.ToDecimal(Console.ReadLine());

area = tamanho * largura;
Console.WriteLine($"A área do terreno é {area} m².");
