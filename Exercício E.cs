using System;
using System.Threading;

namespace ConsoleApp3
{
    internal class Program
    {
        static double notas()
        {
            Console.Write("Digite sua primeira nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite sua segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());

            double media = (n1 + n2) / 2;
            return media;
        }

        static void Main(string[] args)
        {
            int cont = 0;
            int cont1 = 0;
            int cont2 = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Aluno número {i}, Digite seu nome:");
                string nome = Console.ReadLine();
                Console.Write("Digite seu RGM: ");
                string rgm = Console.ReadLine();

                double media = notas();

                if (media >= 5)
                {
                    cont = cont + 1;
                    Console.WriteLine($"O aluno chamado {nome}, RGM:{rgm}, obteve a média de {media} e foi APROVADO !");
                }
                if (media >= 3 && media < 5)
                {
                    cont1 = cont1 + 1;
                    Console.WriteLine($"O aluno chamado {nome}, RGM:{rgm}, obteve a média de {media} e ficou de RECUPERAÇÃO");
                }
                if (media < 3)
                {
                    cont2 = cont2 + 1;
                    Console.WriteLine($"O aluno chamado {nome}, RGM:{rgm}, obteve a média de {media} e foi REPROVADO");
                }

            }
            Console.WriteLine($"O total de Alunos Aprovados: {cont}, Recuperação:{cont1} e Reprovados: {cont2}");
            Console.ReadKey();

        }

    }
}

