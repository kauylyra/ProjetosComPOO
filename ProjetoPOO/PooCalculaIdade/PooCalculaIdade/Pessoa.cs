using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooCalculaIdade
{
    public class Pessoa
    {
        public Pessoa(string nome, int anoNascimento)
        {
            Nome = nome;
            AnoNascimento = anoNascimento;
            CalcularIdade();
        }

        public Pessoa()
        {
        }
        public string Nome { get; private set; }
        public int AnoNascimento { get; private set; }
        public int Idade { get; private set; }
        public string ExibirNome(string nome)
        {
            return Nome = nome;
        }
        public int ExibirAnoNascimento(int anoNascimento)
        {
            return AnoNascimento = anoNascimento;
        }
        public int ExibirIdade(int idade)
        {
            CalcularIdade();
            return Idade = idade;
        }
        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + ExibirNome(Nome));
            Console.WriteLine("Ano de nascimento: " + ExibirAnoNascimento(AnoNascimento));
            CalcularIdade();
            Console.WriteLine("Idade : "+ExibirIdade(Idade));
        }
            
        public void  CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            Idade = ano - AnoNascimento;
        }   
    }
}
