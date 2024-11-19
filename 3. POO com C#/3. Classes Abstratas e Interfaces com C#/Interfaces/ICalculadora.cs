using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._Classes_Abstratas_e_Interfaces_com_C_.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);//Obrigatório para implementação
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2)//Opcional para implementação, se no outro codigo n tiver essa função assume essa função, caso lá tenha ele toma a que ta lá como verdade
        {
            return num1/num2;
        }
    }
}