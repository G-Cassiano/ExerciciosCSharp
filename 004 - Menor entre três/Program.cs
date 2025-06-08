decimal menor, n1, n2, n3;

Console.WriteLine("Digite o primeiro numero: ");
n1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
n2 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o terceiro numero: ");
n3 = Convert.ToDecimal(Console.ReadLine());

if (n1 < n2 || n1 < n3)
{
    menor = n1;
}
else if (n2 < n3)
{
    menor = n2;
}
else
{
    menor = n3;
}

Console.WriteLine($"O menor numero é {menor}");