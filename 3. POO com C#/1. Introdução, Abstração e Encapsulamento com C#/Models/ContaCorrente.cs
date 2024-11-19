using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1._Introdução__Abstração_e_Encapsulamento_com_C_.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial) //Quando eu instanciar vou receber esses valores
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;        
        }
        public int NumeroConta { get; set; }
        private decimal saldo; //Bloqueia as alterações externas 

        public void Sacar(decimal valor) //Método para sacar o valor
        {
            if (saldo>= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque realizador, saldo disponível agora é de {saldo} R$");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo disponível");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo disponível é de {saldo} R$");
        }

    }
}