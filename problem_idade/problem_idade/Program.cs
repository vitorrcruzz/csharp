using System;
using System.Globalization;

namespace problem_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int idade, age;

            string nome, name;

            double media;

            Console.WriteLine("Bem vindo ao Programa \n");

            Console.WriteLine("Média Idade \n");

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("Idade: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine();

            media = (idade + age) / 2.0;

            Console.WriteLine("A idade média de " + nome + " e " 
                + name + " é de " + media.ToString("F1", CI) + " anos");

            Console.ReadKey();
        }
    }
}
