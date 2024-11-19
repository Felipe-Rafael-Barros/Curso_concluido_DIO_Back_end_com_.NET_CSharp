// Arquivo de class, onde você vai fazer sua codificação em C#
// dotnet new console -> Criar arquvios
// dotnet build       -> construir projeto

using Aula_1.Models; // Para usar a class criada, sem isso o programa não aceita


//PascalCase         -> PessoaFisica = Pessoa Fisica
//camelCase          -> pessoaFisica - Pessoa Fisica

Pessoa pessoa1 = new Pessoa();
Pessoa pessoa2 = new Pessoa(); 

pessoa1.Nome = "Felipe"; 
pessoa1   .Idade = 25;
pessoa1.Apresentar();

pessoa2
.Nome = "Diogo";
pessoa2
.Idade = 24;
pessoa2
.Apresentar();

//dotnet run -> rodar o codigo