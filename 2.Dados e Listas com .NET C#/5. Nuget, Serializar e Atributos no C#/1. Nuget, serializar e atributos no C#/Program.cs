// Nuget -> Gerenciador de pacotes
// Um pacote é um conjunto de códigos úteis, que possibilita o compartilhamento e reuso do código
//dotnet add package Newtonsoft.Json // --version 13.0.3
using _1._Nuget__serializar_e_atributos_no_C_.Models;
using Newtonsoft.Json;
DateTime dataAtual = DateTime.Now;

Console.WriteLine("\nParte 1 - NUGET - GERENCIADOR DE PACOTES\n");


//Nuget -> Gerenciador de pacotes, que permite que desenvolvedores compartilharem códigos e bibliotecas


Console.WriteLine("\nParte 2 - Serialização de dados\n");
// Serialização é o processo de transformar objetos em um fluxo de bytes para seu armazenamento ou transmissão.

//Json -> JavaScript Notation Object é o formato de texto que segue a sintaxe do Javascript, muito usado para transmitir dados entre aplicações


Console.WriteLine("\nParte 3 - Serialização de dados na prática\n");

Venda v1 = new Venda(1, "Material de escritório", 25.08M, dataAtual);
string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented); //ou string serializado = JsonConvert.SerializeObject(v1);
Console.WriteLine(serializado);



Console.WriteLine("\nParte 4 - Escrevendo um arquivo JSON\n");
File.WriteAllText("Arquivos/vendas.json", serializado);
List<Venda> listaVendas = new List<Venda>();
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);
listaVendas.Add(v1);
listaVendas.Add(v2);

string serializarLista = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas2.json", serializarLista);
Console.WriteLine(serializarLista);



Console.WriteLine("\nParte 5 - JSON Viewer\n");
//Site que verifica a validação do JSON: https://codebeautify.org/jsonviewer


Console.WriteLine("\nParte 6 - DateTime em JSON\n");
// Já feito durante o progresso do codigo



Console.WriteLine("\nParte 7 - Deserializando um objeto\n");
string conteudoArquivo = File.ReadAllText("Arquivos/vendas2.json");

List<VendasDeserializando> listaVendasDes = JsonConvert.DeserializeObject<List<VendasDeserializando>>(conteudoArquivo);
foreach (VendasDeserializando venda in listaVendasDes)
{
    Console.WriteLine($"ID: {venda.Id},Produto: {venda.Produto}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}


Console.WriteLine("\nParte 7 - Atributos\n");
//Sua propriedade não bate com o que foi enviado ou não bate com a conversão de sintaxe do C#, Nome_Produto -> NomeProduto
//encima da propriedade que quero mudar faça -> [JsonProperty("Nome_Produto)]
//[JsonProperty("Nome_Produto)]
//public string Produto{get;set;}