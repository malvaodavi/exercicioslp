Console.WriteLine("Este é um programa que realiza o cálculo da tabuada do número informado pelo usuário.");
Console.WriteLine("Digite o número que você deseja calcular a tabuada: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"A tabuada de {num} é: ");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
}