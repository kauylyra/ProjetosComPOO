using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerguntaeResposta
{
    public class Pergunta
    {
        //public string testeA = "";  Aparece para qualquer 
        //private string testeB = "";  só essa classe ou quem herda dela vai ver essa variável;
        //protected string testeC = "";  só pertence a essa classe Pergunta, mesmo herdando ela não aparece;
        public Pergunta()
        {

        }
        public Pergunta (string texto, string resposta)
        {
            Texto = texto;
            Resposta = resposta;
        }
       
        public string Texto { get; set; }
        public string Resposta { get; set; }
    }
}
