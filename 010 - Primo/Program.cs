Console.WriteLine($"Digite o numero para saber se é primo ou não: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero == 2 || numero == 3 || numero == 5 || numero == 7 || numero == 11 ||
    numero == 13 || numero == 17 || numero == 19 || numero == 23 || numero == 29)
{
    Console.WriteLine("Número primo.");
}
else
{
    Console.WriteLine("Número não é primo.");
}