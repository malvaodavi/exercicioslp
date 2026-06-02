Console.WriteLine("Este é um programa que realiza o cálculo de 1 até N, sendo N o número informado pelo usuário.");

while (true)
{
    Console.WriteLine("Digite um número inteiro positivo: ");
    string entrada = Console.ReadLine();

    if (int.TryParse(entrada, out int num) && num > 0)
    {
        int soma = 0;

        for (int i = 1; i <= num; i++)
        {
            soma += i;
        }
    Console.WriteLine($"A soma de 1 até {num} é: {soma}");
    break;
    }
    else
    {
        Console.WriteLine("Número inválido.\n");
    }
}