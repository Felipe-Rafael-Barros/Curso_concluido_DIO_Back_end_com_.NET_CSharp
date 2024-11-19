using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1_Propriedades__métodos_e_construtores.Modelos
{
    public class Pessoa
    {
        public Pessoa() // Serve como padrão e n receber nada como entrada
        {

        }
        public Pessoa(string nome, string sobrenome) //Construtor, tem o mesmo nome da sua classe
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        // public qualquer um pode acessar Pessoa.Nome = "Felipe" pode
        //private acesso restrito, so pode acessar dentro da própria classe Pessoa._nome = "Felipe" não pode
        private string _nome; //Aqui armazena o nome(campo) encapisulamento
        private int _idade; //Aqui armazena a idade(campo)

        public string Nome //Propriedade 1
        { 
            get // => _nome.ToUpper();  Body Expressions
            {
                return _nome.ToUpper(); 
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException("O nome não pode ser vazio");
                }
                _nome = value;
            }
            
        } 
        public int Idade //Propriedade 2
        { 
            get => _idade;  //Body Expressions
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
            
        }  


        public string Sobrenome // Propriedade 3
        {
            get;
            set;
        }


        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // Propriedade de somente leitura (só get)
        


        public void Apresentar()
        {
            Console.WriteLine($"Bom dia, meu nome é {NomeCompleto} e tenho {Idade} anos");
        }
    }
}