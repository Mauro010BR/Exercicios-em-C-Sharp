using System;

namespace Exercícios
{
    internal class Program
    {
        static void Dobro(double n1, double n2, double n3)
        {
            double dobro1 = n1 * 2;
            double dobro2 = n2 * 2;
            double dobro3 = n3 * 2;

            Console.WriteLine($"O dobro de {n1},{n2} e {n3} são {dobro1},{dobro2} e {dobro3}");

        }


        static void Main(string[] args)
        {
            //Exercício número 1º

            string resp = "S";

            while (resp == "S")
            {

                Console.WriteLine("\nAqui temos um programa que imprime o dobro de cada número");
                Console.Write("Digite o primeiro número:");
                double n1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o Segundo Número: ");
                double n2 = double.Parse(Console.ReadLine());

                Console.Write("Digite o Terceiro Número:");
                double n3 = double.Parse(Console.ReadLine());

                Dobro(n1, n2, n3);

                Console.WriteLine("Deseja utilizar novamente ?(S/N)");
                resp = Console.ReadLine().ToString().ToUpper();
            }
            Console.ReadKey();
        }
    }
}
