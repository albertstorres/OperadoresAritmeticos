using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES ARITMÉTICOS
            int soma = 25 + 22;
            int subtracao = 25 - 22;
            int divisao = 22 / 5;
            int multiplicacao = 25 * 22;

            Console.WriteLine(soma);
            Console.WriteLine(subtracao);
            Console.WriteLine(divisao);
            Console.WriteLine(multiplicacao);

            int x = 2 + 2 * 2;
            int y = 2 + (2 * 2);
            int z = (2 + 2) * 2;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            //FIM OPERADORES ARITMÉTICOS

            //OPERADORES DE ATRIBUIÇÃO
            int xx = 0;
            xx += 5;
            Console.WriteLine(xx);
            xx -= 1;
            Console.WriteLine(xx);
            xx *= 10;
            Console.WriteLine(xx);
            xx /= 2;
            Console.WriteLine(xx);
            //FIM OPERADORES DE ATRIBUIÇÃO

            double teste = 10;
            teste /= 3;
            Console.WriteLine(teste);
        }
    }
}
