// Tipos especiais no C#

// valor nulo -> (nullable)



using System.Reflection.Metadata;
using _1._Tipos_especiais_no_C_.Models;

Console.WriteLine("\n PARTE 1 - VALOR NULO (NULLABLE) \n");
//bool = true, false
//bool? = true, false, null


// Pode usar "?" para inteiros, floats e etc.

bool desejaaReceberEmail = true;
// bool desejaaReceberEmail = null; da erro por que boll não pode receber valor 

bool? desejaReceberEmail = null; // "bool?" pode receber null

if(desejaReceberEmail.HasValue && desejaReceberEmail.Value) // .HasValue avalei se tem valor a variavel
{
    Console.WriteLine("O usuário optou por receber e-mail.");
}
else
{
    Console.WriteLine("O usuário não respondeu ou não optou por receber e-mail.");
}

Console.WriteLine("\n PARTE 2 - TIPOS ANÔNIMOS \n");
//Fornecem um modelo conveniente de encapsular propriedades somente leitura

var tipoAnonimo = new {Nome = "Leonardo", Sobrenome = "Buta", Altura = 1.80};

Console.WriteLine($" Nome:" + tipoAnonimo.Nome);
Console.WriteLine($" Nome:" + tipoAnonimo.Sobrenome);
Console.WriteLine($" Nome:" + tipoAnonimo.Altura);

//em coleção temos os anônimos na forma:

// var listaAnonimo = listaVenda.Select(x=> new {x.Produto, x.Proco});
//foreach...

Console.WriteLine("\n PARTE 3 - TIPO DINÂMICO \n");
//Cuidado porque se você botar o tipo errado nela quando for capturar o valor pode da uma exeção 

dynamic variavelDinamica = 4; // Ela pode mudar o seu tipo a cada interação
Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = 1.45M;
Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = "Felipe Barros";
Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

Console.WriteLine("\n PARTE 4 - CLASSES GENÉRICAS \n");
// Encapsulam operações que não são específicas de um determinado tipo de dado

MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarEletemntoArray(30);
Console.WriteLine(arrayInteiro[0]);

MeuArray<string> arrayString = new MeuArray<string>();
arrayString.AdicionarEletemntoArray("Felipe");
Console.WriteLine(arrayString[0]);

Console.WriteLine("\n PARTE 5 - MÉTODOS DE EXTENSÃO \n");
// Permitem que você "adicione" tipos existentes sem criar um novo tipo derivado, recompilar ou, caso contrário, modificar o tipo original


int numero = 20;
bool par = false;

//IF Ternário

par = numero.EhPar();

string mensagem = "O número: " + numero + " " + "é " + (par ? "par" : "impar");
Console.WriteLine(mensagem);















