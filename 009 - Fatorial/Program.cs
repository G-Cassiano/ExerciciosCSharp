

Console.WriteLine("Digite o numero para fatorar");
int numero = Convert.ToInt32(Console.ReadLine());
int fatorial = 1;

for (int i = 1; i <= numero; i++)
{
    fatorial *= i;
}
Console.WriteLine($"O numero fatorado é {fatorial}");