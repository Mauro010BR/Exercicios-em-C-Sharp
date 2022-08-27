using System;

namespace Exercício_B
{
    internal class Program
    {

        static void Potencia(double X,double Y)
        {
            double Result = Math.Pow(X, Y);
            Console.WriteLine($"O resultado é {Result} ");

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Vamos fazer uma Potência");
            Console.Write("Digite a Base: ");
            double Base = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o expoente: ");
            double exp = double.Parse(Console.ReadLine());

            Potencia(Base, exp);

            Console.ReadKey();
        }
    }
}
