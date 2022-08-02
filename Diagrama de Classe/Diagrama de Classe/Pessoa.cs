using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_de_Classe
{
    internal class Pessoa
    {
        // Atributo de Classe
        private string nome;
        private int idade = 0;
        private double= altura;
        private string sexo;

        //Construtor sem parametros
        public Pessoa()
        {
         this.nome = null;
         this.idade = 0;
         this.altura = 0.0;
         Sexo = null;


        }
        //Construtor com parametros
        public Pessoa (string nome, int idade, double altura, char sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            Sexo = sexo.ToString();

  
        }
        //Propiedade do campo nome para acesso ao seu conteudo
        public string Nome
        { get { return nome; }  //retorna o valor armazenado em um atributo
          set { nome = value; } //armazena o valor no campo
        }
         //

        //Método que retorna uma string contendo as informações da pessoa
        public override string ToString()
        {
            return(String.Format("Nome: {0}", nome));
        }
    }
}
