using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aulaPoo04
{
    public class Pokemon
    {
        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set {
                string texto = value.ToUpper();
                nome = texto; }
        }

        private string descricao; //armazena o valor da propiedade Descricao.

        public string Descricao //representa a caractristica Descricao do meu Pokemon.
        {
            get { return this.descricao; }
            set { this.descricao = value.ToUpper(); }
        }

        public void ExibirDadosPokemon() //método = ação
        {
            Console.WriteLine("Nome do Pokémon: " + this.Nome);
            Console.WriteLine("Descrição do Pokémon: " + this.Descricao);
        }
    }
}