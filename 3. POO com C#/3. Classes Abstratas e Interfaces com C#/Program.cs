using _3._Classes_Abstratas_e_Interfaces_com_C_.Interfaces;
using _3._Classes_Abstratas_e_Interfaces_com_C_.Models;

Console.WriteLine("PARTE 1 - Introdução a Classes Abstratas em C#");
// Classe abstrata tem como objetivo ser exclusivamente um modelo para ser herdado, portanto não pode ser instanciada
//Você pode implementar métodos ou deixá-los a cargo de quem herda

Corrente c  = new Corrente();
c.Creditar(500);
c.ExibirSaldo();


Console.WriteLine("PARTE 2 - Introdução a classe selada em C#");
//Impedir que outras classes façam uma herança dela, ou seja, nenhum classe pode ser sua derivada
//Também existem métodos e propriedades seladas.

//public sealed class Corrente : Conta //sealed

//Pode também:
// public sealed override void ExibirSaldo(){}


Console.WriteLine("PARTE 3 - Introdução a classe object em C#");

// A classe System.Object é a mãe de todas as classes na hierarquia do .NET
// Todas as classes derivam, direta ou indiretamente da class Object, e ela tem como objetivo prover serviços de baixo nível para suas classes filhas.



Computador comp1 = new Computador();

Console.WriteLine(comp1.ToString());


Console.WriteLine("PARTE 4 - Introdução a interfaces em C#");
// Uma interface é um contrato que pode ser implementado por uma classe
//É como se fosse uma classe abstrata, podendo definir métodos abstratos para serem implementados.
//Assim como uma classe abstrata, uma interface não pode ser instanciada.

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3,9));

// Método padrão na inferface é dado por:












