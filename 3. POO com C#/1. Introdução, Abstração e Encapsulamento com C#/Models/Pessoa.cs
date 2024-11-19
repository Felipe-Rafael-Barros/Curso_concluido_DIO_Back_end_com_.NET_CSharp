using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1._Introdução__Abstração_e_Encapsulamento_com_C_.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar()  // Virtual habilita que ele seja sobrescrito
        {
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos");
        }

    }
}