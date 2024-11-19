// Introdução array
// Array pe yna estrutura de dados que armazena valores do mesmo tipo, com um tamanho fixo



Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

Console.WriteLine("\nPARTE 1 - ARRAYS\n");
int[] array = new int[4];
int[] array2 = new int[]{42,75,74,61}; //Posição 0->42,1->75,2->74 e 3->61.
string[] nomes = {"Janeiro", "Fevereiro"};

int [] arrayInteiros = new int[3]; //Declara o tamanho do array

arrayInteiros[0]=72;
arrayInteiros[1]=64;
arrayInteiros[2]=50;
Console.WriteLine("Percorrendo Arrays com FOR\n");
for(int contador=0; contador<arrayInteiros.Length/*tamanho do array */; contador++ )
{
    Console.WriteLine($"Posição Nº {contador} = {arrayInteiros[contador]}");
}

//Console.WriteLine("\nPARTE 2* - ARRAYS ACESSANDO POSIÇOES QUE NÃO EXISTEM\n");

//Console.WriteLine($"Posição Nº {3} = {arrayInteiros[3]}"); 
/*Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
   at Program.<Main>$(String[] args) in C:\Users\Felipe Barros\Desktop\VsCode\Dio\C#\Sintaxe Básica com .NET C#\6. Array e Listas em C#\1. Array e Listas em C#\Program.cs:line 26
*/

Console.WriteLine("\nPARTE 2.2 - ARRAYS PERCORRENDO COM FOREACH\n");
Console.WriteLine("Percorrendo Arrays com FOREACH\n");

int ContadorForeach =0;
foreach(int valor in  arrayInteiros) // Para cada no array de int vc jogar o valor para "valor"
{
    Console.WriteLine($"Posição Nº {ContadorForeach} = {valor}");
    ContadorForeach++;
}


Console.WriteLine("\nPARTE 3 - REDIMENSIONANDO UM ARRAYS \n");


Console.WriteLine($"TAMANHO DO ARRAY ANTES DO REDIMENSIONADO: {arrayInteiros.Length}");
Array.Resize(ref arrayInteiros, arrayInteiros.Length*2); //Dobrando o tamanho do ARRAY (REFERENCIA DO ARRAY QUE QUER MUDAR, E O NOVO TAMANHO)
Console.WriteLine($"TAMANHO DO ARRAY REDIMENSIONADO: {arrayInteiros.Length}");


Console.WriteLine("\nPARTE 4 - COPIANDO UM ARRAYS PARA OUTRO \n");

int [] ArrayNovo = new int[2];
ArrayNovo[0] = 2;
ArrayNovo[1] = 4;

int[] ArrayTeste4 = new int [ArrayNovo.Length*2];
Array.Copy(ArrayNovo,ArrayTeste4, ArrayNovo.Length);
Console.WriteLine($"ARRAY COPIADO: {ArrayTeste4.Length}");

// Em uma lista não precisamos declarar sua capacidade, tem facilidade para remover, adicionar e fazer consultas
Console.WriteLine("\nPARTE 5 - TRABALHANDO COM LISTAS \n");

List<string> listaString = new List<string>(); //Declarando lista

//Adicionar
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
//Retirar
listaString.Remove("MG");


Console.WriteLine("\nPercorrendo Lista com FOR\n");
for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição Nº {contador} = {listaString[contador]}");
}


Console.WriteLine("\nPercorrendo Lista com FOREACH\n");
int ContadorForeAch =0;
foreach(string item in  listaString) // Para cada no array de int vc jogar o valor para "valor"
{
    Console.WriteLine($"Posição Nº {ContadorForeAch} = {item}");
    ContadorForeAch++;
}

Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
