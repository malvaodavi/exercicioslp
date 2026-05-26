Console.WriteLine("Este é um programa que determina qual categoria de  idade uma pessoa pertence em uma escola de natação, com base na idade informada pelo usuário.");
Console.WriteLine("Digite a idade do nadador: ");
int idade = int.Parse(Console.ReadLine());

if (idade >= 0 && idade <= 10)
{
    Console.WriteLine("O nadador pertence à categoria Infantil.");
}
else if (idade > 10 && idade <= 17)
{
    Console.WriteLine("O nadador pertence à categoria Juvenil.");
}
else if (idade > 17)
{
    Console.WriteLine("A pessoa pertence à categoria Adulto.");
}
else
{
    Console.WriteLine("Idade inválida. Por favor, insira uma idade válida.");
}