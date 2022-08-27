using System;
using System.Reflection.PortableExecutable;

namespace Exercício_D
{
    internal class Program
    {

        static void calculo(double altu, string sex)
        {
            if(sex == "M")
            {
                double pesom = (72.7 * altu) - 58;
                Console.WriteLine($"Peso ideal masculino é F2:{pesom:f2}");
            }
            if(sex == "F")
            {
                double pesof = (62.1 * altu) - 44.7;
                Console.WriteLine($"Peso ideal feminino é {pesof:f2}");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Iremos calcular seu peso ideal");
            Console.Write("Digite sua altura: ");
            double alt = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu Sexo (M/F)");
            string sex = Console.ReadLine().ToString().ToUpper();

            while(sex != "M" && sex != "F")
            {
                Console.Write("Código inválido, Digite novamente o sexo: ");
                sex = Console.ReadLine().ToString().ToUpper();

            }

            calculo(alt, sex);

            Console.ReadKey();
        }
    }
}
