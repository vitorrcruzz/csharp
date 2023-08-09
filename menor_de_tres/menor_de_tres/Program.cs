using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menor_de_tres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n1, n2, n3, menor;

            Console.WriteLine("Bem vindo ao Programa \n");

            Console.WriteLine("Menor de três \n");

            Console.Write("Digite o primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            n3 = int.Parse(Console.ReadLine());

            if(n1 < n2 && n1 < n3)
            {
                menor = n1;
            }
            else if(n2 < n3)
            {
                menor = n2;
            }
            else
            {
                menor = n3;
            }

            Console.WriteLine("O menor número é: " + menor);

            Console.ReadKey();
        }
    }
}
