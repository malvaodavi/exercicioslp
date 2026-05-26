Console.WriteLine("Este é um programa que determina o tipo do triângulo, de acordo com os lados informados pelo usuário.");
Console.WriteLine("Digite o primeiro lado do triângulo: ");
double lado1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo lado do triângulo: ");
double lado2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro lado do triângulo: ");
double lado3 = double.Parse(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("O triângulo é equilátero.");
}
else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
{
    Console.WriteLine("O triângulo é isósceles.");
}
else
{
    Console.WriteLine("O triângulo é escaleno.");
}