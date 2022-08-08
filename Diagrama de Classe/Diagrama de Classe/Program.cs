using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_de_Classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 15;
            Pessoa[] p = new Pessoa[TAM];//declaração do vetor de pessoas
            int c = 0; //variável que servirá como um cortador de pessoas cadastradas
            int op = 0;
            do {
                op = menu();
                switch (op) {

                    case 1: p[c++] = cadastrarPessoa(); break;

                    case 2: listarPessoa(p, c); break;

                    case 3: exibirMediaPesoIdeal(p, "MASCULINO", c); break;

                    case 4: exibirMediaPesoIdeal(p, "FEMININO", c); break;

                    case 0: break;

                    default: Console.WriteLine("Opção Invalida. "); break;
                }
                Console.SetCursorPosition(50, 20);
                Console.Write("Tecle algo para continuar!");
                Console.ReadKey();
            }while(op != 0);
            
            public static int menu()
            {
                Console.Clear();
                Console.WriteLine("*** Menu Principal - Pessoa ***\n");
                Console.WriteLine(" 1 - Cadastrar");
                Console.WriteLine(" 2 - Listar todas as pessoas");
                Console.WriteLine(" 3 - Média do Peso Ideal dos Homens");
                Console.WriteLine("");
            }
            Console.Write("Digite o nome da pessoa: "); string n = Console.ReadLine();
            Console.Write("Digite a idade de {0}:   ", n); int i = int.Parse(Console.ReadLine());
            Console.Write("Digite a altura de {0}", n); double a = double.Parse(Console.ReadLine());
            Console.Write("Digite a letra correpondente ao sexo(F/m):  ");
            char s = char.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(n, i, a, s);

            Console.WriteLine("\n \n *** Dados da Pessoa ***\n");
            Console.WriteLine(pessoa.ToString());
            Console.WriteLine(" Pesso Ideal: {0}", pessoa.calcularPesoIdeal());
            Console.ReadKey();

        }
    }
}
