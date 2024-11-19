using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1._Operadores_Aritméticos_e_a_class_Math.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");

        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");

        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");

        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");

        }

        public void Potência(int x, int y)
        {
            double potência = Math.Pow(x,y);
            Console.WriteLine($"{x}^{y} = {potência}");

        }
        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180; 
            double Cos = Math.Cos(radiano);
            Console.WriteLine($"Cos({angulo}) = {Math.Round(Cos,4)}");

        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180; 
            double Sen = Math.Sin(radiano);
            Console.WriteLine($"Sin({angulo})= {Math.Round(Sen,4)}");

        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180; 
            double Tan = Math.Tan(radiano);
            Console.WriteLine($"Tang({angulo}) = {Math.Round(Tan,4)}");

        }
        public void Incremento(int x)
        {
            x++;
            Console.WriteLine($"{x-1}++ => {x++}");

        }
        public void Decremento(int x)
        {
            x--;
            Console.WriteLine($"{x+1}-- => {x}");

        }
        public void RaizQuadrada(double x)
        {

            Console.WriteLine($"√({x})-- => {Math.Sqrt(x)}");

        }
    }
}