decimal numero;

Console.WriteLine("Digite o numero pra exibir a tabuada: ");
numero = Convert.ToDecimal(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i} x {numero} = {i * numero}");
}