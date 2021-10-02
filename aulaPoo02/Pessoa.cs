using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aulaPoo02
{
    public class Pessoa
    {
        public Pessoa()
        {
            this.Nome = "";
            this.Idade = 0;
        }

        public Pessoa(String nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private int idade;
        public int Idade 
        { 
            get { return idade; }
        
            set
            {
                if (idade >= 0)
                {
                    idade = value;
                }
                else
                {
                    this.idade = 0;
                }
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine("A pessoa mais velha é: ");
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Idade: {this.Idade}");
        }
    }
}