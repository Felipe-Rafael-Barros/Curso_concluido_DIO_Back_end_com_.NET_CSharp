
using _1_Propriedades__métodos_e_construtores.Modelos;

Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");


Console.WriteLine("\nPARTE 1 -  Propriedades e métodos\n");
Console.WriteLine("Propriedade - Membro que oferece um mecanismo flexível para ler, gravar ou calcular o valor de um campo particular\n");

Pessoa p1 = new Pessoa("Felipe","Barros");

p1.Idade = 25;
p1.Apresentar();
// get  => _nome.ToUpper();  Body Expressions
Console.WriteLine("\nPARTE 2 -  Métodos\n");

Console.WriteLine("Um método é um bloco de código que contém uma série de instruções\n");

Pessoa p2 = new Pessoa();
p2.Nome = "Eduardo";
p2.Sobrenome = "Neves Queiroz";

Curso CursoDeIngles = new Curso();
CursoDeIngles.Nome = "Inglês";
CursoDeIngles.Alunos = new List<Pessoa>();
CursoDeIngles.AdicionarAluno(p1);
CursoDeIngles.AdicionarAluno(p2);
CursoDeIngles.ListarAlunos();

Console.WriteLine("\nPARTE 3 -  Construtores\n");

Console.WriteLine("Construtores permitem que o programador defina valores padrão, limite a instanciação e grave códigos flexíveis e fáceis de ler.\n");


Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
