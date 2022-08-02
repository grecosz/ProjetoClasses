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
            // Criação de um objeto p, do tipo da classe Pessoa
            Pessoa p = new Pessoa();

            // Exibindo na tela informações do objeto p
            // Realizando uma chamada no método ToString
            Console.WriteLine(p.ToString());

            // Atribuindo um nome ao objeto p, por meio da propriedade nome
            p.Nome = "Nivia";

            //Exibindo na tela informações do objeto p,
            // após a atribuição do nome
            Console.WriteLine(p);
            Console.ReadKey();

        }
    }
}
