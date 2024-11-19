using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1._Introdução__Abstração_e_Encapsulamento_com_C_.Models
{
    public class ProfessorExPolimorfismo : Professor
    {
        public override void Apresentar() //Override para sobrescrever
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou professor,  Tenho {Idade} anos e ganho aproximadamente {salário} R$ por mês. ");
        }
    }
}