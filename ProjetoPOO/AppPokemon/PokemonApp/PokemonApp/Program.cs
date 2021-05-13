using System;

namespace PokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int resposta = 100;
            while (resposta != 0)
            {
                resposta = Menu();
                Console.Clear();
                if (resposta == 1)
                {
                    pokedex.ListarPokemons();
                }
                if(resposta ==2)
                {
                    pokedex.ListarPokemons();
                    Console.WriteLine("Digite o código do pokemon que quer usar para Batalha");
                    int codigo = int.Parse(Console.ReadLine());
                    //Pegar o pokemon do player;
                    PokemonPlus pokemonPlayer = pokedex.Pokemons[codigo];
                    //Definir o Pokemon do pc;
                    Random r = new Random();
                    codigo = r.Next(0, pokedex.Pokemons.Count);
                    PokemonPlus pokemonDoPc = pokedex.Pokemons[codigo];
                    // Batalhar;
                    Console.WriteLine("\nDados dos Pokemons que irão lutar : ");
                    Console.WriteLine("\nDados do seu Pokemon");
                    pokemonPlayer.ExibirDadosPokemonPlus();

                    Console.WriteLine("\nDados Pokemon do PC");
                    pokemonDoPc.ExibirDadosPokemonPlus();
                    if (pokemonPlayer.Poder > pokemonDoPc.Poder)
                    {
                        Console.WriteLine("Parabéns você ganhou!!!");

                    }
                    else
                    {
                    Console.WriteLine("Que pena, você perdeu.");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        static int Menu()
        {
            Console.WriteLine("Pokemon --Jogo de batalha");
            Console.WriteLine("0 - Sair do jogo");
            Console.WriteLine("1 - Listar todos os pokemons da pokedex.");
            Console.WriteLine("2 - Entrar na Batalha.");
            Console.WriteLine("Escolha uma das opções: ");
            int resposta = int.Parse(Console.ReadLine());
            return resposta;
        }
    }
}
