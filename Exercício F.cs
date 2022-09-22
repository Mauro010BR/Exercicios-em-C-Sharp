using System;
using System.Threading;

namespace ConsoleApp3
{
    internal class Program
    {
        static void vetor(double[] num)
        {
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Digite um número real: ");
                num[i] = double.Parse(Console.ReadLine());



            }
        }
        static void numero(double[] num)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (num[i] % 2 == 0)
                {
                    double par = num[i] * 5;
                    Console.WriteLine($"Numero {num[i]} Par = {par}");
                }
                else
                {
                    double impar = num[i] + 5;
                    Console.WriteLine($"Número {num[i]} impar = {impar}");
                }
            }
        }
        static void Main(string[] args)
        {
            double[] num = new double[10];
            Console.WriteLine("");
            vetor(num);
            numero(num);
            Console.ReadKey();
        }  
    }
 
}

