using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primeira pessoa
            Console.WriteLine("Programa que verifica qual usuário é mais velho.");
            Console.WriteLine("Digite o primeiro nome: ");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Digite o ano em que nasceu: ");
            int idade1 = int.Parse(Console.ReadLine());
            Pessoa pessoa1 = new Pessoa(nome1, idade1);

            //segunda pessoa
            Console.WriteLine("\nDigite o segundo nome: ");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Digite o ano em que nasceu: ");
            int idade2 = int.Parse(Console.ReadLine());
            Pessoa pessoa2 = new Pessoa(nome2, idade2);

            //terceira pessoa
            Console.WriteLine("\nDigite o terceiro nome: ");
            string nome3 = Console.ReadLine();
            Console.WriteLine("Digite o ano em que nasceu: ");
            int idade3 = int.Parse(Console.ReadLine());
            Pessoa pessoa3 = new Pessoa(nome3, idade3);

            //Exibir a pessoa que é mais velha:
            if ((pessoa1.Idade > pessoa2.Idade) && (pessoa1.Idade > pessoa3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                pessoa1.ExibirDados();
            }
            if ((pessoa2.Idade > pessoa1.Idade) && (pessoa2.Idade > pessoa3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                pessoa2.ExibirDados();
            }
            if ((pessoa3.Idade > pessoa1.Idade) && (pessoa3.Idade > pessoa2.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                pessoa3.ExibirDados();
            }
            Console.ReadKey();
        }
    }
}
