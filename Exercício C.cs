using System;

namespace Exercício_C
{
    internal class Program
    {
        static void Retorno(int A,int B,int C)
        {
            int resul = Math.Max(A, B);
            int res = Math.Max(resul, C);

            Console.WriteLine(res);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 Números e iremos retornar o maior deles");

            Console.Write("Digite o Primeiro Número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo Número:");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o Terceiro Número: ");
            int n3 = int.Parse(Console.ReadLine());

            Retorno(n1, n2, n3);

            Console.ReadKey();
        }
    }
}
