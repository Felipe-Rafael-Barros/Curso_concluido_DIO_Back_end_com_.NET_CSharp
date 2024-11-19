//Introdução POO

using _1._Introdução__Abstração_e_Encapsulamento_com_C_.Models;

Console.WriteLine("PARTE 1 - POO");
// POO é um paradigma de programação, ou seja, corresponde a uma técnica de programação para um fim específico
// Dentro desta técnica, existem 4 pilares:

//1. Abstração
//2. Encapsulamento
//3. Herança
//4. Polimorfismo

Console.WriteLine("PARTE 2 - POO - Paradigmas de programação");
// Um paradgima é um modelo de técnicas, estruturas e formas de solucionar um problema

Console.WriteLine("Paradigmas:\n 1º POO\n 2º Programação estruturada\n 3º Programação imperativa\n 4º Programação procedural\n 5º Programação orientada a eventos\n 6º Programação lógica\n");


Console.WriteLine("PARTE 3 - POO - Abstração");
// Abstrair um objeto do mundo real para um contexto específico, considerando apenas os atributos importantes.

Pessoa p1 = new Pessoa();
p1.Nome = "Felipe";
p1.Idade = 25;
p1.Apresentar();

Console.WriteLine("\nPARTE 4 - POO - Introdução a Encapsulamento");
// O encapsulamento serve para proteger uma classe e definir limites para alteração de suas propriedades.
// Ou seja, serve para ocultar seu comportamento e expor somente o necessário.

ContaCorrente c1 = new ContaCorrente(123,1990);
//c1.saldo -> não pode ser acessado por que é privado
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();

Console.WriteLine("\nPARTE 5 - POO - Introdução a Heramça");
//Herança nos permite reutilizar atributos, métodos e comportamentos de uma classe em outras classes.
//Serve para agrupar objetos que são do mesmo tipo, porém com caractertísticas diferentes.
//classe aluno, professor herdam da class pessoa (nome, Idade)
//     public class Professor : Pessoa //Declaração hernaça de uma classe para outra
Aluno a1 = new Aluno();

a1.Nome = "FelipeB";
a1.Idade = 26;
a1.Nota = 7.30M;
a1.Apresentar();
a1.ApresentaNota();

Professor prof1 = new Professor();


prof1.Nome = "Nando";
prof1.Idade = 35;
prof1.salário = 3601.85M;

prof1.Apresentar();
prof1.ApresentarSalario();

//Herança multipla de uma vez so n da, só é possível em C# herdar uma classe por vez


Console.WriteLine("\nPARTE 5 - POO - Introdução Polimorfismo");

// Polimorfismo -> "muitas formas"
//Podemos com ele sobrescrever métodos das classes filhas para que se comportem de maneira diferente e ter sua própria implementação

AlunoExPolimorfismo Al1 = new AlunoExPolimorfismo();
ProfessorExPolimorfismo Pro1 = new ProfessorExPolimorfismo();

Pro1.Nome = "Eduardo";
Pro1.Idade = 30;
Pro1.salário = 1000;
Pro1.Apresentar();

Al1.Nome = "Carlos";
Al1.Idade = 21;
Al1.Nota = 8;
Al1.Apresentar();