Console.WriteLine("Este é um programa que realiza a conversão de temperatura de graus Celsius para Fahreinheit.");
Console.WriteLine("Digite a temperatura em graus Celsius: ");
float temp = float.Parse(Console.ReadLine());

Console.WriteLine($"A temperatura {temp}°C em Fahrenheit é: {(temp * 9/5) + 32}°F");