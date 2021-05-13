using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIdade
{
    public class Pessoa
    {
        public Pessoa()
        {
            Nome = "";
            Idade = 0;
        }
        public Pessoa(string nome,int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public string Nome { get;private set; }
        public int Idade { get;private set; }

        public string SetNome(string nome)
        {
            Nome = nome;
            return Nome;
        }
        public int SetIdade(int idade)
        {
            Idade = idade;
            return idade;
        }
        public void ExibirDados()
        {
            Console.WriteLine("\nNome: " + SetNome(Nome) + "\nIdade: "+ SetIdade(Idade));
        }
    }
}
