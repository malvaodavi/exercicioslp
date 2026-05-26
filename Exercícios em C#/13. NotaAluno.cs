Console.WriteLine("Este é um programa que verifica a nota de um aluno e exibe se ele foi aprovado ou reprovado.");
Console.WriteLine("Digite a nota do aluno: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 6)
{
    Console.WriteLine("O aluno foi aprovado.");
}
else
{
    Console.WriteLine("O aluno foi reprovado.");
}

