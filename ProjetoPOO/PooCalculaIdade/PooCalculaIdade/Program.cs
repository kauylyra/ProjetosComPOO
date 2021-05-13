using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooCalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("programa para calcular a idade da pessoa.");
            Console.WriteLine("Digite seu nome: ");
            string nome = (Console.ReadLine());

            Console.WriteLine("Digite o ano em que nasceu: ");
            int ano = int.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(nome,ano);
            pessoa.ExibirDados();
            Console.ReadKey();
        }
    }
}
