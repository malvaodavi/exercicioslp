Console.WriteLine("Este programa irá calcular o fatorial do número informado pelo usuário.");

while(true)
{
    Console.WriteLine("Digite um número inteiro e positivo: ");
    string entrada = Console.ReadLine();
    
    if (int.TryParse(entrada, out int num) && num > 0)
    {
        int fator = 1;
        
        for (int i = 1; i <= num; i++)
        {
            fator *= i;
        }
        Console.WriteLine($"O fatorial de {num} é: {fator}.");
        break;
    }
    else
    {
        Console.WriteLine("Número inválido.\n");
    }

}