using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            bool saiu = false;
            while (!saiu)
            {
                ExibirMenu();
                option = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 0:
                        saiu = true;
                        break;
                    case 1:
                        Console.WriteLine("Insira sua mensagem: ");
                        string msg = Console.ReadLine();
                        EscreverArquivo(msg);
                        Console.Clear();
                        break;
                    case 2:
                        LerArquivo();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }

        static void ExibirMenu()
        {
            Console.WriteLine("[1] - Escrever mensagem em arquivo binário\n[2] - Ler arquivo de texto\n[0] - Sair");
        }
        static void EscreverArquivo(string mensagem)
        {
            FileStream stream = new FileStream(@"C:\Users\Aluno\source\repos\Exercicio02\Exercicio02\ex02.bin", FileMode.Create);
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(mensagem);
            writer.Flush();
            writer.Close();
        }
        static void LerArquivo()
        {
            StreamReader reader = new StreamReader(@"C:\Users\Aluno\source\repos\Exercicio02\Exercicio02\ex01.txt");
            while (!reader.EndOfStream)
            {
                string linha = reader.ReadLine();
                Console.WriteLine(linha);
            }
            reader.Close();
            Console.ReadKey();
        }
    }
}
