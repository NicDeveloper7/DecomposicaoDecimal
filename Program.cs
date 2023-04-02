int numero;

Console.WriteLine("Digite um número inteiro: ");
numero = int.Parse(Console.ReadLine()!);
int centenas = numero / 100;
int dezenas = (numero / 10) % 10;
int unidades = numero % 10;

Console.WriteLine($"O número {numero} possui: ");
Console.WriteLine($"{dezenas} Dezena (s)");
Console.WriteLine($"{unidades} Unidade (s)");
Console.WriteLine($"{centenas} Centena (s)");
