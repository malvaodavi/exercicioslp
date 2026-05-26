Console.WriteLine("Este é um programa que lê os números informados pelo usuário e retorna qual o maior e o menor número.");
Console.WriteLine("Digite o primeiro número: ");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine($"O maior número é: {Math.Max(numero1, numero2)}"); // Math.Max() é um método da classe Math que retorna o maior valor entre os dois números informados.Exercícios em C#/7. MaiorMenor.cs