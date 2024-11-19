int a = 10;
int b = 20;
int c = a + b; //Soma e atribui em c
int d = a + b;
Console.WriteLine("Parte 1:\n");
Console.WriteLine(c);
Console.WriteLine("\n");

c = c + 5;
d += 5;
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine($"c:{c} e d:{d}");

c = 5;

Console.WriteLine(c);
Console.WriteLine("\n");

Console.WriteLine("Parte 2:\n");
// Cast - Casting - Conversao de uma String para Inteiro
//caso tenha uma letra ele quebra o codigo
int p = Convert.ToInt32("5"); // CONVERT
int h = int.Parse("10");     //  PARSE
Console.WriteLine(p);
Console.WriteLine(h);
Console.WriteLine($"p:{p} e h:{h}");

//Diferença entra Convert e Parse
// CONVERTE ACEITA NULO E ESCREVE 0 QUANDO RECEBE "null" (USE MAIS)
// JÁ O PARSE DA ERRO(PARA O PROGRAMA) CASO RECEBA O PARÂMETRO "null"    (TENTE NÃO USAR MUITO)


Console.WriteLine("\nParte 3:");

//Conversão de um Inteiro para uma String
int inteiro = 5;
string Jota = inteiro.ToString();


Console.WriteLine(Jota);


Console.WriteLine("\nParte 4 Cast Implícito:");

// Cast Implícito

int bh = 5;
double by = bh;
Console.WriteLine($"by:{by} e bh:{bh}");



// Ordem dos operadores
Console.WriteLine("\nParte 5 Ordem dos operadores:");

double y = 4 / 2 + 2;
double z = 4 / (2+2);
Console.WriteLine($"y:{y} e z:{z}");

Console.WriteLine("\nParte 6 Conversão de maneira segura:");
string g = "14-a";
int u = 0;
int.TryParse(g,out u);  //Vou tentar converter o g, se eu conseguir vai se o u
Console.WriteLine($"g:{g} e u:{u}");