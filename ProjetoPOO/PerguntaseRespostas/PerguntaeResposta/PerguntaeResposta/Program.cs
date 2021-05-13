using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerguntaeResposta
{
    class Program
    {
        static void Main(string[] args)
        {
            PerguntaPlus p = new PerguntaPlus();
            p.Texto = "Qual é o site que possui um ótimo conteúdo sobre programação";
            p.Resposta = "https://alura.com.br";
            p.Dica = "O site trata-se de cursos em programação";

            Console.WriteLine("Tente Adivinhar a pergunta.");
            Console.WriteLine("Pergunta " + p.Texto);
            Console.WriteLine("Dica : " + p.Dica);
            Console.Write("Resposta: ");
            string resposta = Console.ReadLine();

            if (p.Resposta.ToUpper() == resposta.ToUpper())
            {
                Console.WriteLine("Parabéns você acertou");
            }
            else
            {
                Console.WriteLine("Você Errou!!");
                Console.WriteLine("A resposta correta é : " + p.Resposta);
            }
            Console.ReadKey();
        }
    }
}
