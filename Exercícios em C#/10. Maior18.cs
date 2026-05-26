Console.WriteLine("Este é um programa que valida se a idade do usuário é maior de 18 anos.");
Console.WriteLine("Digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Você é maior de 18 anos.");
}
else
{
    Console.WriteLine("Você é menor de 18 anos.");
}