Console.WriteLine("Este é um programa que realiza o cálculo da área de um círculo.");
Console.WriteLine("Digite o raio do círculo em centímetros: ");
float raio = float.Parse(Console.ReadLine());

Console.WriteLine($"A área do círculo é {3.14159 * raio * raio:F4}cm²."); // Desconsiderei o uso da biblioteca Math por se tratar de um cálculo simples. 