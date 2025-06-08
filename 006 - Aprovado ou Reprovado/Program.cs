decimal nota;

Console.WriteLine("Digite a nota");
nota = Convert.ToDecimal(Console.ReadLine());

if (nota >= 6)
{
    Console.WriteLine($"Aprovado com nota {nota}");
}
else
{
    Console.WriteLine($"Reprovado com nota {nota}");
}
