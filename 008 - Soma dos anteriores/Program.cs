decimal numero, soma = 0, adicao = 0;

Console.WriteLine("Digite o numero para somar os antecessores");
numero = Convert.ToDecimal(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    soma += i;
}
Console.WriteLine($"A soma dos numeros antecessores é: {soma}");