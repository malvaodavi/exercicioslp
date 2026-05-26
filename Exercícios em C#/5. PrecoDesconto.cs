Console.WriteLine("Este é um programa que calcula o preço de um produto com desconto de X porcentagem.");
Console.WriteLine("Digite o preço do produto: ");
double preco = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a porcentagem de desconto: ");
double desconto = double.Parse(Console.ReadLine());

Console.WriteLine($"O preço do produto com desconto é de R${preco - (preco * desconto / 100):F2}");