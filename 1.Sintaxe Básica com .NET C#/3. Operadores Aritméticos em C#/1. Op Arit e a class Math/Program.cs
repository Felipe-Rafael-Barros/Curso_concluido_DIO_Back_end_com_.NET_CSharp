//    Introdução operadores aritméticos
//    +,-,*,/ -> Padrões
//    % -> resto
//   ++ -> incremento de 1
//   -- -> decremento de 1

using _1._Operadores_Aritméticos_e_a_class_Math.Models;

Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

Calculadora calculadora = new Calculadora();


Console.WriteLine("\nParte 1 - Operações Básicas");
calculadora.Somar(10,5);
calculadora.Subtrair(10,5);
calculadora.Multiplicar(10,5);
calculadora.Dividir(10,5);
calculadora.Potência(10,5);

Console.WriteLine("\nParte 2 - Operações Trigonométricas");

calculadora.Cosseno(45);
calculadora.Seno(45);
calculadora.Tangente(40);

Console.WriteLine("\nParte 3 - Operações Incremento/Decremento");

calculadora.Incremento(45);
calculadora.Decremento(40);

Console.WriteLine("\nParte 4 - Operações de Raiz Quadrada");

calculadora.RaizQuadrada(25);
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
