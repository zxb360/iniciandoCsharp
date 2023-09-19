// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vamos calcular seu IMC - Indice de massa corporal");
Console.WriteLine("Qual é seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("E... diga ai, quanto você pesa?");
decimal peso = decimal.Parse(Console.ReadLine());
Console.WriteLine("Qual é sua altura hoje?");
decimal altura = decimal.Parse(Console.ReadLine());

//calculando o imc 
decimal imc = peso / (altura * altura);
var media = imc.2m;
// Console.WriteLine(media);

if (media < 18)
{
    Console.WriteLine("Você está abaixo do peso");
};
if (media < 24)
{
    Console.WriteLine("Peso Normal");
};

if (media > 25)
{
    Console.WriteLine("Você está acima do peso" );
};

