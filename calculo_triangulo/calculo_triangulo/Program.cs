using System;
using System.Globalization;

namespace calculo_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double a, b, h;

            Console.WriteLine("Bem vindo ao Programa \n");

            Console.WriteLine("Cálculo da área de qualquer triângulo \n");

            Console.Write("Digite o valor da base (b): ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de h: ");
            h = double.Parse(Console.ReadLine());

            a = b * h / 2;

            Console.WriteLine("\n A área do Triângulo é: " + a);
            Console.ReadKey();
        }
    }
}
