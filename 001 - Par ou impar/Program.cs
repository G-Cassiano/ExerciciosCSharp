int numero;

Console.WriteLine("Digite o numero: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("O numero é par");
}
else
{
    Console.WriteLine("O numero é impar");
}
