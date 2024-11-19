// Operadores condicionais
//If, else, switch, casa
// && (and)
// || (or)
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

//PARTE 1 - IF E ELSE

Console.WriteLine("\nPARTE 1 - IF E ELSE\n");
int QuantidadeEmEstoque = 10;
int QuantidadeCompra = 0;
Console.WriteLine($"É possível realizar a venda? {QuantidadeEmEstoque>=QuantidadeCompra && QuantidadeCompra>0}\n");
if (QuantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if (QuantidadeEmEstoque >= QuantidadeCompra)
{
    Console.WriteLine("Venda realizada");
    QuantidadeEmEstoque = QuantidadeEmEstoque - QuantidadeCompra;
    Console.WriteLine($"Temos em estoque disponível: {QuantidadeEmEstoque}");
}

else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
}

Console.WriteLine("\nPARTE 2 - SWITCH CASE\n");

//PARTE 1 - SWITCH CASE

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é uma vogal!");
        break;
}



Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
