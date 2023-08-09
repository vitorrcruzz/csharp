using System;

namespace soma_impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, troca, soma;
            Console.WriteLine("Bem vindo ao programa \n");

            Console.WriteLine("Digite dois números: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if(x > y)
            {
                troca = x;
                x = y;
                y = troca;
            }
            soma = 0;
            for(int i = x+1; i < y; i++)
            {
                if(i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine("Soma dos Impares = " + soma);
            Console.ReadKey();
        }
    }
}
