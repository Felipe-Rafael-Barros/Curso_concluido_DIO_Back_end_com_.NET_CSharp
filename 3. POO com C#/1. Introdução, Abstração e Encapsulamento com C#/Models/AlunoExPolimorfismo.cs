using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1._Introdução__Abstração_e_Encapsulamento_com_C_.Models
{
    public class AlunoExPolimorfismo : Aluno
    {
        public override void Apresentar() //Override para sobrescrever
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou aluno,  Tenho {Idade} anos e minha nota é {Nota}. ");
        }
    }
}