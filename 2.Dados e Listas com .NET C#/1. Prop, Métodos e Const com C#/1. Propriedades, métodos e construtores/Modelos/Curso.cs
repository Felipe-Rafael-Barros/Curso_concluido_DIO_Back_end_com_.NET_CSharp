using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1_Propriedades__métodos_e_construtores.Modelos
{
    public class Curso
    {
        public string Nome{get; set;}
        public List<Pessoa> Alunos {get; set;}

        public void AdicionarAluno(Pessoa aluno) // Void -> retorno vazio
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()// Retorna um inteiro
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public void RemoverAluno( Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }
        public void ListarAlunos()
        {
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}