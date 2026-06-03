Console.WriteLine("Este programa irá validar se o número fornecido pelo usuário é um número ímpar ou par.");

while (true)
{
    Console.WriteLine("Digite um número inteiro e positivo: ");
    string entrada = Console.ReadLine();

    if (int.TryParse(entrada, out int num) && num > 0)
    {

        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} é um número par.");

        }
        else
        {
            Console.WriteLine($"{num} é um número ímpar.");
        }

        break;
    }

    else
    {
        Console.WriteLine("Número inválido.\n");
    }
}