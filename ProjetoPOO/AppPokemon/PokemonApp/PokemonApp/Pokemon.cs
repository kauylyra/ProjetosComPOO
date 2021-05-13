using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    public class Pokemon
    {
        public Pokemon() // Base 
        {

        }
        public Pokemon(string nome, string descricaoPokemon)
        {
            Nome = nome;
            DestricaoPokemon = descricaoPokemon;
        }
        
       public string Nome { get; private set; }
       public string DestricaoPokemon { get; private set; }

        public string SetNomePokemon(string nome)
        {
            Nome = nome; // Armazena o valor do Nome do Pokemon;
            return Nome;
        }

        public string SetDadosPokemon(string descricaoPokemon)
        {
            DestricaoPokemon = descricaoPokemon; //Armazena o valor de Descrição do Pokemon;
            return DestricaoPokemon;
        }

        public void ExibirDadosPokemon()
        {
            Console.WriteLine("\nNome do Pokemon: " + Nome + "\nDescrição do Pokemon: "+ DestricaoPokemon);
        }
    }
}
