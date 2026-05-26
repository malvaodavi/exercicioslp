Console.WriteLine("Este é um programa que informa se o número informado pelo usuário é um número par ou ímpar.");
Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é um número par.");
}
else
{
    Console.WriteLine($"O número {numero} é um número ímpar.");
}