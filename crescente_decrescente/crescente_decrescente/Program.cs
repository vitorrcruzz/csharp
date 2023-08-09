using System;

namespace crescente_decrescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            Console.WriteLine("Bem vindo ao programa \n");

            Console.WriteLine("Digite dois número: ");
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            while (X != Y)
            {
                if (X < Y)
                {
                    Console.WriteLine("Crescente");
                }
                else if (X > Y)
                {
                    Console.WriteLine("Decrescente");
                }

                Console.WriteLine("Digite outros dois números: ");
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Fim do programa.");
            Console.ReadKey();


        }
    }
}
