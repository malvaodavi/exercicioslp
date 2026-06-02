Console.WriteLine("Este é um programa que determina qual é o seu IMC (Índice de Massa Corporal) e se você está abaixo do peso, com peso normal, sobrepeso ou obesidade.");
Console.WriteLine("Digite o seu peso em kg:");
double peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a sua altura em metros:");
double altura = Convert.ToDouble(Console.ReadLine());
double imc = peso / (altura * altura);

if (imc < 18.5)
{
    Console.WriteLine($"O seu IMC é {imc:F2} e você está abaixo do peso.");
}
else if (imc >= 18.5 && imc < 25)
{
    Console.WriteLine($"O seu IMC é {imc.ToString("F2")} e você está com peso normal.");
}
else if (imc >= 25 && imc < 30)
{
    Console.WriteLine($"O seu IMC é {imc.ToString("F2")} e você está com sobrepeso.");
}
else
{
    Console.WriteLine($"O seu IMC é {imc.ToString("F2")} e você está com obesidade.");
}