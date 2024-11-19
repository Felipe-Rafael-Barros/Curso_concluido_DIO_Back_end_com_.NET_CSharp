// Tipos de dados

/*  1) string -> palavras
    2) char -> caracters
    3) object ->
    4) bool -> Verdadeiro ou Falso
    5) long -> variação de int
    6) int -> inteiro (-2b até +2b)
    7) float -> nºs com casas decimais
    8) decimal -> trabalhando com Reais
    9) double -> mais preciso que o float



*/

string Apresentacao = "Olá, seja bem vindo. Abaixo as informações referente ao código:\n";
int Quantidade = 1;
double  Altura = 1.80;
decimal Preco = 1.85M;
float AlturaFloat = 1.23F;
bool Condicao = true;


Console.WriteLine(Apresentacao);
Console.WriteLine($"Valor da variável quantidade:" + Quantidade);
Console.WriteLine($"Valor da variável Altura:" + Altura.ToString("0.00"));
Console.WriteLine($"Valor da variável Preço:" + Preco);
Console.WriteLine($"Valor da variável Altura com float:" + AlturaFloat);
Console.WriteLine($"Valor da variável Condição:" + Condicao);

//Ctrl+K+C, comenta a linha de codigo todo

DateTime dateTime = DateTime.Now; // Data atual do Pc usado
DateTime dateTime2 = DateTime.Now.AddDays(5); // Data atual + dias/meses/anos

Console.WriteLine($"\nData atual 1:   " + dateTime);
Console.WriteLine($"Data atual 1:   " + dateTime.ToString("dd/mm/yyyy"));

Console.WriteLine($"Data atual 2:   " + dateTime2);
Console.WriteLine($"Data atual 2:   " + dateTime2.ToString("dd/mm/yyyy HH:mm"));
Console.WriteLine($"Data atual 2:   " + dateTime2.ToString("HH:mm"));