using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1._Tipos_especiais_no_C_.Models
{
    public static class IntExtensions
    {
        public static bool EhPar(this int numero)//Extendendo o comportamento do inteiros
        {
            return numero%2 ==0;
        }
    }
}