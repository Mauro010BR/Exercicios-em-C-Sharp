using System;

namespace exercício_G
{
    internal class Program
    {
        static void matriz(int[,] matrizA, int linha, int coluna)
        {
            for(int i = 0; i < linha; i++)
            {
                for(int j = 0; j < coluna; j++)
                {
                    Console.Write("Entre com o valor: ");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void calculo(int[,] matrizA, int[,] matrizB,int linha,int coluna, int K)
        {
            for(int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    matrizB[i, j] = matrizA[i, j] * K;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Quantas linhas deseja ?:");
            int linha = int.Parse(Console.ReadLine());

            Console.Write("Quantas colunas deseja ?: ");
            int coluna = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de K: ");
            int K = int.Parse(Console.ReadLine());

            int[,] matrizA = new int[linha,coluna];
            int[,] matrizB = new int[linha, coluna];

            matriz(matrizA, linha, coluna);
            calculo(matrizA, matrizB, linha, coluna, K);

            for(int i = 0; i < linha; i++)
            {
                for(int j = 0; j < coluna; j++)
                {
                    Console.Write($"{matrizB[i, j]}  ");
                }
                Console.WriteLine();
            }


        }
    }
}
