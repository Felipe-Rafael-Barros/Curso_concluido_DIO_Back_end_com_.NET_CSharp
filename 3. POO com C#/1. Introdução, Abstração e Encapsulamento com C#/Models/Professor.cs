using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1._Introdução__Abstração_e_Encapsulamento_com_C_.Models
{
    public class Professor : Pessoa
    {
        public decimal salário { get; set; }
        public void ApresentarSalario()
        {
            Console.WriteLine($"O salário do professor {Nome} é {salário} R$");
        }
    }
}