using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Introdução_a_APIs_com_C_.Entities
{
    public class Contato
    {
        [Key]  // Crio a chave primária
        public int Id{get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
        
    }
}