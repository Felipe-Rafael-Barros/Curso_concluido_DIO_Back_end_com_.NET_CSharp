using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._Classes_Abstratas_e_Interfaces_com_C_.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }


    }
}