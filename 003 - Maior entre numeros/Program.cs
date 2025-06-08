decimal numero1, numero2;

Console.WriteLine("Digite o primeiro numero");
numero1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");
numero2 = Convert.ToDecimal(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine($"O maior numero é {numero1}");
}
else
{
    Console.WriteLine($"O maior numero é {numero2}");
}
