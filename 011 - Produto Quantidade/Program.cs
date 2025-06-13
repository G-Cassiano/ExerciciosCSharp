int escolha, quantidade;
decimal total;

Console.Write("1 - Bala Halls\n2 - Trident \n3 - Picolé \n4 - Pipoteca\nEscolha o produto (Pela numeração): ");
escolha = Convert.ToInt32(Console.ReadLine());

while (escolha > 4)
{
    Console.Write("Produto Invalido!\nDigite a numeração:");
    escolha = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Digite a quantidade: ");
quantidade = Convert.ToInt32(Console.ReadLine());

switch (escolha)
{
    case 1:
        total = (quantidade * 5.30m);
        Console.WriteLine($"Total: R${total}");
        break;
    case 2:
        total = (quantidade * 6.00m);
        Console.WriteLine($"Total: R${total}");
        break;
    case 3:
        total = (quantidade * 3.20m);
        Console.WriteLine($"Total: R${total}");
        break;
    case 4:
        total = (quantidade * 2.50m);
        Console.WriteLine($"Total: R${total}");
        break;
    default:
        Console.WriteLine("Produto invalido");
        break;
    return;
}