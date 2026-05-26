Console.WriteLine("Este é um programa que realiza o cálculo da área de um círculo.");
Console.WriteLine("Digite o raio do círculo: ");
float raio = float.Parse(Console.ReadLine());

Console.WriteLine($"A área do círculo é {3.14159 * (Math.Pow(raio, 2))}");