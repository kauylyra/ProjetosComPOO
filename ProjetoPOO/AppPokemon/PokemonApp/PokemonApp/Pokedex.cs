using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    public class Pokedex
    {
        public Pokedex()
        {
            InicializaLista();
        }
        private List<PokemonPlus> pokemons;

        public List<PokemonPlus>Pokemons
        {
            get { return pokemons; }
        }

        private void InicializaLista()
        {
            //Instanciar a Lista;
            pokemons = new List<PokemonPlus>();
            //Inserir 10 pokemons na lista.
            //p [0]
            PokemonPlus p = new PokemonPlus("\nBulbassauro","Tipo Planta",100);
            pokemons.Add(p);

            //p [1]
            p = new PokemonPlus("\nPikachu", "tipo Elétrico", 90);
            pokemons.Add(p);

            //p [2]
            p = new PokemonPlus("\nCharmander", "tipo fogo", 95);
            pokemons.Add(p);

            //p [3]
            p = new PokemonPlus("\nOnix", "tipo Pedra", 50);
            pokemons.Add(p);

            //p [4]
            p = new PokemonPlus("\nMew", "lendário tipo Psíquico", 70);
            pokemons.Add(p);

            //p [5]
            p = new PokemonPlus("\nMewTwo", "lendário tipo Psíquico", 65);
            pokemons.Add(p);

            //p [6]
            p = new PokemonPlus("\nSquirtle", "tipo água", 80);
            pokemons.Add(p);

            //p [7]
            p = new PokemonPlus("\nButterfly", "tipo Planta", 95);
            pokemons.Add(p);

            //p [8]
            p = new PokemonPlus("\nRatatá", "tipo Terra", 75);
            pokemons.Add(p);

            //p [9]
            p = new PokemonPlus("\nPidgey", "tipo Voador", 35);
            pokemons.Add(p);
        }

        public void ListarPokemons()
        {
            for (int i = 0; i < Pokemons.Count; i++)
            {
                Console.WriteLine("Código do Pokemon : "+ i);
                Pokemons[i].ExibirDadosPokemon();
                //Pokemon p = Pokemons[i];
                //p.ExibirDadosPokemon();
            }
        }
    }
    
}
