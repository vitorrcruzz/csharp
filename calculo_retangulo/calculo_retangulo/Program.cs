using System;
using System.Globalization;

namespace calculo_retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            /*area retangulo: a = b * h 
              perimetro: p = 2 * (b + h)
             diagonal: d^2 = b^2 + h^2*/

            double a, b, d, h, p;
             

            Console.WriteLine("Bem vindo ao Programa \n");

            Console.WriteLine("Cálculo área retangulo \n");

            Console.Write("Digite a base do retângulo: ");
            b = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite a altura do retângulo: ");
            h = double.Parse(Console.ReadLine(), CI);

            a = b * h;
            p = 2 * (b + h);
            d = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(h, 2.0));

            Console.Write("Área: " + a.ToString("F4", CI) + "\n");
            Console.Write("Perimetro: " + p.ToString("F4", CI) + "\n");
            Console.Write("Diagonal: " + d.ToString("F4", CI) + "\n");

            Console.ReadKey();
        }
    }
}
