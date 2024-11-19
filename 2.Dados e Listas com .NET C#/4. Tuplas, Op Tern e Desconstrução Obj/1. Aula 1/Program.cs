using _1._Aula_1.Models;

Console.WriteLine("\nPARTE 1 - TUPLAS\n");

(int Id, string Nome, string Sobrenome) tupla = (25, "Felipe", "Barros"); //Declaração tuplas

Console.WriteLine($"Idade: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");


Console.WriteLine("\nPARTE 2 - OUTRA SINTAXE DA TUPLA\n");
ValueTuple<int,string,string> outroExemploTupla = (25,"Felipe", "Barros");
var outroExemploTuplaCreate = Tuple.Create(25,"Felipe", "Barros");


Console.WriteLine($"Idade: {outroExemploTupla.Item1}");
Console.WriteLine($"Nome: {outroExemploTupla.Item2}");
Console.WriteLine($"Sobrenome: {outroExemploTupla.Item3}");



Console.WriteLine("\nPARTE 3 - TUPLA EM UM MÉTODO\n");

LeituraArquivo arquivo = new LeituraArquivo();

var(sucesso,linhasArquivos, quantidadeLinhas) = arquivo.LerArquivo("Arquivo/arquivoLeitura.txt");
if (sucesso)
{
    Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
    foreach(string linha in linhasArquivos)
    {
        Console.WriteLine(linha);
    }

}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}


Console.WriteLine("\nPARTE 4 - DESCARTES\n");

var(sucesso2,_,_) = arquivo.LerArquivo("Arquivo/arquivoLeitura.txt"); // O "_" Descarta a informação


Console.WriteLine("\nPARTE 5 - DESCONSTRUTOR\n");
//Separar os objetos em variáveis distintas

//public void Desconstruct(out string nome, out string sobrenome)
// {
//     nome = Nome;
//     sobrenome = Sobrenome;

// }


//Pessoa p1 = new Pessoa("Leonardo", "Buta");
//(string nome, string sobrenome) = p1


Console.WriteLine("\nPARTE 6 - IF TERNÁRIO\n");

int numero = 10;
bool ePar = false;

//IF TERNÁRIO só pode 2 condições
ePar = numero % 2 == 0;

Console.WriteLine($"O número {numero} é " + (ePar ? "par" : "impar"));



