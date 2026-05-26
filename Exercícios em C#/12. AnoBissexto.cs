Console.WriteLine("Este é um programa que verifica se o ano informado pelo usuário se trata de um ano bissexto ou não.");
Console.WriteLine("Digite um ano para verificar se ele é bissexto ou não: ");
int ano = int.Parse(Console.ReadLine());

if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
{
    Console.WriteLine($"O ano {ano} é um ano bissexto.");
}
else
{
    Console.WriteLine($"O ano {ano} não é um ano bissexto.");
}