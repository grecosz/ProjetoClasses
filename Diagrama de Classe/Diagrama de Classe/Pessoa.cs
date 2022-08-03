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
        public int Idade
        {
          get { return idade; }
          set { idade = value; }
        }
        public double Altura
        {
          get { return altura; }
          set { Altura = value; }
        }

        public string Sexo
        {
          get { return sexo; }
          set { sexo = value.ToUpper() == "M" ? "MASCULINO" : "FEMININO"; }

        }

        // Método para calcular o peso ideal de uma pessoa
        public double calcularPesoIdeal()
        {
            if (sexo.Equals("MASCULINO"))
                return (72.7 * altura) - 58;
            else
                return (62.1 * altura) - 44.7;

        }


        //Método que retorna uma string contendo as informações da pessoa
        public override string ToString()
        {
            return(String.Format("Nome: {0}\n Idade: {1} \n Altura:{2} \n Sexo: {3} \n",
                                    nome, Idade, Altura, sexo));
        }
    }
}
