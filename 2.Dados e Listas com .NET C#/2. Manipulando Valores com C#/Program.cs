using System.Globalization;// Usado na parte 5


// Concatenação de Strings
Console.WriteLine("\nParte 1 - Concatenação\n");

string String1 = "Felipe";
string String2 = "Barros";
string Concatenação = String1+String2;
Console.WriteLine(Concatenação);

Console.WriteLine("\nParte 2 - Interpolação\n");
//Interpolação

string Interpolação = $"{String1} {String2}";
Console.WriteLine(Interpolação);

Console.WriteLine("\nParte 3 \n");

string numero1 = "10";
string numero2 = "20";
string resultado = numero1+numero2;
Console.WriteLine(resultado);

Console.WriteLine("\nParte 4 - Formatar valores monetários \n");

decimal valorMonetario = 1582.40M;
Console.WriteLine($"{valorMonetario:C} pt-BR");

Console.WriteLine("\nParte 5 - Alterara a localização do sistema \n");

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
Console.WriteLine($"{valorMonetario:C} en-US");


Console.WriteLine("\nParte 6 - Alterara a localização da cultura \n");
Console.WriteLine($"{valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))} en-US padronizando cultura");


Console.WriteLine("\nParte 7 - Formatação personalizada \n");
Console.WriteLine(valorMonetario.ToString("C5")); // Tamanho de casas decimais
Console.WriteLine(valorMonetario.ToString("N8")); // Tamanho de casas decimais do numero sem R$ 



Console.WriteLine("\nParte 8 - Representar Porcentagem \n");

double porcentagem = .3421;
int numero = 123456;
Console.WriteLine(porcentagem.ToString("P"));
Console.WriteLine(numero.ToString("##-##-##"));

Console.WriteLine("\nParte 9 - Formatar o tipo DateTime \n");
DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));


Console.WriteLine("\nParte 10 - Formatando data e hora \n");
Console.WriteLine(data.ToShortDateString()); // exibe apenas a data
Console.WriteLine(data.ToShortTimeString()); // exibe horas

DateTime data2 = DateTime.Parse("10/04/2022 18:00"); // se tiver errado (35dias exemplo) o sistema da erro e encerra
Console.WriteLine(data2);


Console.WriteLine("\nParte 11 - TryParse \n");
string dataString = "2022-02-02 18:00";


bool sucesso = DateTime.TryParseExact(dataString,
                        "yyyy-MM-dd  HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None , 
                        out DateTime data3);



Console.WriteLine(data3);

Console.WriteLine("\nParte 12 - TryParse \n");

if (sucesso)
{
    Console.WriteLine("Conversão com sucesso!");
}
else
{
    Console.WriteLine("Não é uma data válida");
}


