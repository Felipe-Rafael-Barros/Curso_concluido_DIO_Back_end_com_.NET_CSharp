using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Introdução_a_APIs_com_C_.Entities; //Para o DBset identificar minha pasta Entities

namespace Introdução_a_APIs_com_C_.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos{get;set;} //Contatos será o nome. Criamos a entidade
    }
}