using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._Classes_Abstratas_e_Interfaces_com_C_.Models
{
    public abstract class Conta //abstract
    {
        protected decimal saldo; //protegido contra op externar porem as filhas podem alterar

        public abstract void Creditar(decimal valor);
        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é {saldo} R$");
        }
    }
}