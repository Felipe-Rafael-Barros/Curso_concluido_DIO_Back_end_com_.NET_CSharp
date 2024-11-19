using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_1.Models
{
    public class Pessoa // Classe do objeto
    {       // prop e tab ja cria a primeira parte
        // Atributos da class
        public string Nome { get; set; } 

        public int Idade { get; set; }

        public int Telefone { get; set; }

        // Ação do objeto
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} " +
             $" tenho {Idade} anos e caso queira conversar comigo\nmeu número é {Telefone}");  // Escrever informação no terminal
        }

    }
}