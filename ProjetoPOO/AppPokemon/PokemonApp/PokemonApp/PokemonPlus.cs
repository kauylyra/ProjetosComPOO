using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    public class PokemonPlus : Pokemon
    {
        public PokemonPlus():base()
        {
            Poder = 0;
        }
        public PokemonPlus(string nome, string descricaoPokemon,int poder) : base( nome,  descricaoPokemon)
        {
            Poder = poder;
        }
        public int Poder { get; set; }
        public void ExibirDadosPokemonPlus()
        {
            Console.WriteLine("\nNome do Pokemon: " + Nome + "\nDescrição do Pokemon: " + DestricaoPokemon+ "\n Poder: " + Poder);
        }
    }
}
