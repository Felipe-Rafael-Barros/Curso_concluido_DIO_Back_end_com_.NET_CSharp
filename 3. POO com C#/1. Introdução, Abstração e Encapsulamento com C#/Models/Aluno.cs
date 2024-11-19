using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1._Introdução__Abstração_e_Encapsulamento_com_C_.Models
{
    public class Aluno : Pessoa //Declaração de herança
    {
        public decimal Nota { get; set; }

        public void ApresentaNota()
        {
            Console.WriteLine($"A nota do aluno {Nome} é {Nota}");
        }
    }
}