//Declaração de variável
int numero;

Console.WriteLine("Decomposição Decimal");

//Pede para o usuário digitar um número inteiro
Console.WriteLine("Digite um número inteiro: ");
numero = int.Parse(Console.ReadLine()!);

//Realiza as operações para descobrir as unidades, dezenas e centenas
int centenas = numero / 100;
int dezenas = (numero / 100) % 10;
int unidades = numero % 10;

//Exibe as dezenas, unidades, centenas
Console.WriteLine($"O número {numero} possui: ");
Console.WriteLine($"{dezenas} Dezena (s)");
Console.WriteLine($"{unidades} Unidade (s)");
Console.WriteLine($"{centenas} Centena (s)");
