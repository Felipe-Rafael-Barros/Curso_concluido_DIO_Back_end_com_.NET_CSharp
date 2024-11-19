// Exceptions são recursos em C# que ajudam você a lidar com quaisquer situações inesperadas que ocorram quando um programa for executado


using _1._Exceções_e_Coleções.Models;

Console.WriteLine("\nPARTE 1 - EXCEPTIONS\n");
string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
// string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt"); daria erro, exception pq não ia conseguir encontrar o arquivo
foreach(string linha in linhas)
{
    Console.WriteLine(linha);
}



Console.WriteLine("\nPARTE 2 - EXCEPTIONS GENÉRICA E ESPECÍFICA\n");

try
{
    string[] linhas2 = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");
    foreach(string linha in linhas2)
    {
        Console.WriteLine(linha);
    }
} 
catch (FileNotFoundException ex) // EXCEPTION ESPECÍFICO PARA FILE
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrador. {ex.Message}");
}
catch (DirectoryNotFoundException ex) // EXCEPTION ESPECÍFICO PARA DIRETÓRIO
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
}
catch (Exception ex) // Genérico ( ABRENGE TODOS OS EXCEPTION)
{
    Console.WriteLine($"Ocorreu uma exceção genérica {ex.Message}");
}

Console.WriteLine("\nPARTE 3 - ENTENDENDO O BLOCO FINALLY\n");

try
{
    string[] linhas3 = File.ReadAllLines("Arquivos/pasta1/arquivoLeitura.txt");
    foreach(string linha in linhas3)
    {
        Console.WriteLine(linha);
    }
} 
catch (FileNotFoundException ex) // EXCEPTION ESPECÍFICO PARA FILE
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrador. {ex.Message}");
}
catch (DirectoryNotFoundException ex) // EXCEPTION ESPECÍFICO PARA DIRETÓRIO
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
}
catch (Exception ex) // Genérico ( ABRENGE TODOS OS EXCEPTION)
{
    Console.WriteLine($"Ocorreu uma exceção genérica {ex.Message}");
}
finally // Após a verificações ele roda esse último bloco
{
    Console.WriteLine($"\nChegou até aqui!");
}

Console.WriteLine("\nPARTE 4 - THROW \n"); 

new ExemploExcecao().Metodo1();


Console.WriteLine("\nPARTE 5 - INTRODUÇÃO A FILAS - COLEÇÕES - QUEUE \n"); 
// Entrada em ordem e saida baseada nos primeiros a darem entrada. (primeiro que entra é o primeiro que sai)


Queue<int> fila = new Queue<int>(); // Declaração da fila

fila.Enqueue(2); // ADICIONAR ELEMENTOS NA FILA

fila.Enqueue(4); 
fila.Enqueue(6); 
fila.Enqueue(8); 

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nRemovendo um elemento da fila \n"); 

fila.Dequeue(); //Remove o 2

foreach(int item in fila)
{
    Console.WriteLine(item);
}


Console.WriteLine("\nPARTE 6 - INTRODUÇÃO A PILHAS - COLEÇÕES - STACK \n"); 
// O ULTIMO QUE ENTROU É O PRIMEIRO A SAIR (CONTRÁRIO DA FILA)

Stack<int> pilha = new Stack<int>(); // Declaração da pilha

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nRemovendo um elemento da pilha \n"); 

pilha.Pop();

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nPARTE 7 - INTRODUÇÃO A DICIONÁRIO \n"); 
// Elementos únicos para cada chave, não tem ordem específica de saida mas a chave é única para casa valor
//Chave é a referência
// CHAVES SO PODE TER UM TIPO POR DICIONARIO MAS VALOR PODE SE REPETIR NO MESMO DICIONARIO
Dictionary<string,string> estados = new Dictionary<string, string>(); // Declaração de dicionário

estados.Add("SP","São Paulo");
estados.Add("PE","Pernambuco");
estados.Add("MG","Minas Gerais");

foreach(var item in estados) // ou foreach(KeyValuePair<string,string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("\nRemovendo um elemento do dicionário \n"); 

estados.Remove("SP"); // REMOVENDO SÓ PASSAR A CHAVE

foreach(var item in estados) // ou foreach(KeyValuePair<string,string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("\nAlterando o valor da uma chave \n"); 

estados["SP"] = "São Paulo - valor alterado";

foreach(var item in estados) // ou foreach(KeyValuePair<string,string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("\nVerificando se já existe uma chave no dicionário \n");

string chave = "BA";
if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente, não da para adicionar o valor {chave}");
}
else
{
    Console.WriteLine($"Valor não existente, é seguro adicionar a chave: {chave}");

}

Console.WriteLine("\nComo obtermos o valor de uma chave que já existe \n");

Console.WriteLine(estados["MG"]);