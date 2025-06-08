decimal nota = 0, media;

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine($"Digite a nota {i}");
    nota += Convert.ToDecimal(Console.ReadLine());
}
media = nota / 3;

Console.WriteLine($"A media das notas é de {media:F2}");