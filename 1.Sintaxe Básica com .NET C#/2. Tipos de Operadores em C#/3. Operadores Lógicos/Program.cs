//Introdução a operadores lógicos



Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
// Operador OR (Pipe, ||)
Console.WriteLine("\nParte 1 - OPERADOR OR\n");
 bool ehMaiorDeIdade = true;
 bool possuiAutorizacaoDoResponsavel = false;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada");
}
else
{
    Console.WriteLine("Entrada não liberada");
}

// Operador AND (&&)
Console.WriteLine("\nParte 2 - Operador AND \n");

bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media>= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}

// Operador NOT (!)
Console.WriteLine("\nParte 3 - Operador NOT \n");

bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Vou pedalar um outro dia");
}

Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
