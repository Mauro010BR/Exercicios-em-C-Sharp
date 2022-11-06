using System;

namespace ConsoleApp11
{
    internal class Program
    {
        public struct dados
        {
            public string nome;
            public int idade;
            public int online;
        }
        static void Main(string[] args)
        {
            dados[] inf = new dados[3];
            string opc = "S";

            while (opc == "S")
            {
                Console.WriteLine("Que opção deseja, (1) Cadastrar, (2) Listar, (3) Editar (4) Excluír");
                int escolha = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (escolha)
                {
                    case 1:
                        enviar(inf);
                        Console.Clear();
                        Console.WriteLine("Deseja voltar para lista ? (S/N)");
                        opc = Console.ReadLine().ToString().ToUpper();
                        Console.Clear();
                        break;
                    case 2:
                        mostrar(inf);
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Deseja voltar para lista ? (S/N)");
                        opc = Console.ReadLine().ToString().ToUpper();
                        Console.Clear();
                        break;
                    case 3:
                        editar(inf);
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Deseja voltar para lista ? (S/N)");
                        opc = Console.ReadLine().ToString().ToUpper();
                        Console.Clear();
                        break;
                    case 4:
                        excluir(inf);
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Deseja voltar para lista ? (S/N)");
                        opc = Console.ReadLine().ToString().ToUpper();
                        Console.Clear();
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("O programa irá se encerrar !");
            Console.ReadKey();
        }
        static void enviar(dados[] inf)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Digite seu Nome: ");
                inf[i].nome = Console.ReadLine();

                Console.Write("Digite sua Idade: ");
                inf[i].idade = int.Parse(Console.ReadLine());

                inf[i].online = 1;
                Console.Clear();
            }
        }
        static void mostrar(dados[] inf)
        {
            Console.WriteLine("NOME:\t IDADE:\t");

            for(int i = 0; i < 3; i++)
            {
                if (inf[i].online == 1)
                {
                    Console.Write($"{inf[i].nome}");
                    Console.Write($"\t{inf[i].idade}");
                    Console.WriteLine("");
                }
            }
        }
        static void editar(dados[] inf)
        {
            Console.WriteLine("Deseja editar qual pessoa, Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Clear();


            for (int i = 0; i < 3; i++)
            {
                if (inf[i].nome == nome)
                {
                    Console.WriteLine($"NOME:{inf[i].nome}");
                    Console.WriteLine($"IDADE:{inf[i].idade}");
                    Console.WriteLine("");

                    Console.WriteLine("Deseja Alterar para qual Nome: ");
                    string alnome = Console.ReadLine();

                    Console.WriteLine("Desejea alter para Qual idade: ");
                    int idade = int.Parse(Console.ReadLine());

                    inf[i].nome = alnome;
                    inf[i].idade = idade;

                    Console.Clear();
                    Console.WriteLine("Cadastro editado com Sucesso !");
                }
            }
        }
        static void excluir(dados[] inf)
        {
            Console.WriteLine("Deseja excluír qual pessoa, Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < 3; i++)
            {
                if (inf[i].nome == nome)
                {
                    Console.WriteLine($"NOME:{inf[i].nome}");
                    Console.WriteLine($"IDADE:{inf[i].idade}");
                    Console.WriteLine("");
                    Console.WriteLine("Tem certeza que deseja excluír o Cadastro");
                    string escolha = Console.ReadLine().ToString().ToUpper();

                    if (escolha == "S")
                    {
                        while (escolha != "S" && escolha != "N")
                        {
                            Console.WriteLine("Comando Inválido, Digite Novamente: ");
                            escolha = Console.ReadLine().ToString().ToUpper();
                        }

                        inf[i].online = 0;
                        Console.WriteLine("Cadastro excluído com Sucesso !");
                    }
                    else
                    {
                        Console.WriteLine("Cadastro não será apagado !");
                    }
                    
                }
            }
        }
    }
}
