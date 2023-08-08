using System;
using System.Globalization;

namespace calculo_trapezio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double b1, b2, h, area;

            Console.WriteLine("Bem-vindo ao programa \n");

            Console.WriteLine("Cálculo da base de um trapézio \n");

            Console.WriteLine("Digite o valor de b1: ");
            b1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de b2: ");
            b2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor h: ");
            h = double.Parse(Console.ReadLine());

            area = (b1 + b2) / 2.0 * h;

            Console.WriteLine("\n A área do trapézio é: " + area + "cm²");
            Console.ReadKey();
        }
    }
}
