// Estruturas de Repetição

Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("\nParte 1 - FOR");
int numero = 5;
int numero2 = 2;


for(int contador =0; contador<=10; contador++) //Tabuada do numero
{
    Console.WriteLine($"{numero}x{contador} = {numero*contador}");
}


Console.WriteLine("\nParte 2 - WHILE");
int contagem =0;
while (contagem <= 10)
{
    Console.WriteLine($"{numero2}x{contagem} = {numero2*contagem}");
    contagem++;
}


Console.WriteLine("\nParte 3 - interromper o fluxo de execução (Break)");

int contagem3 =0;
while (contagem3 <= 10)
{
    Console.WriteLine($"{numero2}x{contagem3} = {numero2*contagem3}");
    contagem3++;
    if (contagem3 == 5)
    {
        break;
    }
}

Console.WriteLine("\nParte 4 - DO WHILE");
int soma = 0, numeroSoma = 0;
do{
    Console.WriteLine("Digite um Número: (Se digitar 0 para a soma)");
    numeroSoma = Convert.ToInt32(Console.ReadLine());
    soma += numeroSoma;
} while(numeroSoma != 0);
Console.WriteLine($"O valor da soma foi {soma}");
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

Console.WriteLine("\nParte 5 - MENU INTERATIVO");

string opcao;
while(true) // Passe uma variavel com (variavel=true) e na hora de encerrar o while faça variavel=false para refatorar o codigo e codigo continua embaixo
{
    Console.WriteLine("Digite uma opção");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastrar cliente\n");
            break;
        case "2":
            Console.WriteLine("Buscar cliente\n");
            break;
        case "3":
            Console.WriteLine("Apagar cliente\n");
            break;
        case "4":
            Console.WriteLine("Encerrar\n");
            Environment.Exit(0);  //Codição de encerrar o codigo completo, se tiver mais codigo embaixo ele não vai rodar
            break;
        default:
            Console.WriteLine("Opção Invalida\n");
            break;

    }
}