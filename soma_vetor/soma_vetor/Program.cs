using System;
using System.Globalization;

namespace soma_vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n;

            double media, soma;

            Console.WriteLine("Bem vindo ao programa \n");

            Console.Write("Quantos números serão digitados? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um número: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine();
            Console.Write("Valores: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(vet[i].ToString("F2", CI) + " ");
            }
            Console.WriteLine();

            soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma = soma + vet[i];
            }
            Console.WriteLine("Soma: " + soma.ToString("F2", CI));

            media = soma / n;
            Console.WriteLine("Média: " + media.ToString("F2", CI));

            Console.ReadKey();

        }
    }
}
