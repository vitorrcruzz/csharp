using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n;

            Console.WriteLine("Bem vindo ao programa \n");

            Console.Write("Quantos números serão digitados? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um número: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine("Os números digitados foram: ");
            for (int i = 0;i < n; i++)
            {
                Console.WriteLine(vet[i].ToString("F1"));
            }

            Console.ReadKey();
        }
    }
}
