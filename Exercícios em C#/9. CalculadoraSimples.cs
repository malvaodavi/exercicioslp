Console.WriteLine("Este é um programa que simula uma calculadora simples. Ele lê dois números e a operação desejada pelo usuário e retorna o resultado da operação.");
Console.WriteLine("Digite o primeiro número: ");
double numero1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
double numero2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a operação desejada (+, -, *, /): ");
string operacao = Console.ReadLine();

if (operacao == "+")
{
    Console.WriteLine($"O resultado da soma é: {numero1 + numero2}");
}
else if (operacao == "-")
{
    Console.WriteLine($"O resultado da subtração é: {numero1 - numero2}");
}
else if (operacao == "*")
{
    Console.WriteLine($"O resultado da multiplicação é: {numero1 * numero2}");
}
else if (operacao == "/")
{
    if (numero2 != 0) // Condicional aplicada para evitar divisão por zero, que causaria um erro no programa.
    {
        Console.WriteLine($"O resultado da divisão é: {numero1 / numero2}");
    }
    else
    {
        Console.WriteLine("Erro: Divisão por zero não é permitida.");
    }
}
else
{
    Console.WriteLine("Operação inválida. Por favor, escolha entre +, -, *, /."); // Mensagem de erro para caso o usuário digite uma operação que não seja reconhecida pelo programa.
}