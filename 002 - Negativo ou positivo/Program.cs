int numero;

Console.WriteLine("Digite o numero para descobrir se e negativo ou positivo ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero == 0)
{
    Console.WriteLine("Seu numero é Nulo");
}
else if (numero < 0)
{
    Console.WriteLine("Seu numero é Negativo");
}
else
{
    Console.WriteLine("Seu numero é Positivo");
}
