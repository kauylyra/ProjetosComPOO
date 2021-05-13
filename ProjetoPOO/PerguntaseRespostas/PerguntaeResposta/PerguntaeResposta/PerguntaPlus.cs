using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerguntaeResposta
{
    public class PerguntaPlus : Pergunta
    {
        public PerguntaPlus() : base()// "base()" vai executar o construtor da classe base (Pergunta)
        {
            Dica = "";
        }
        // usando o Construtor da classe Pergunta e passando os parâmetros desta classe (PERGUNTAPLUS) para a classe base (Pergunta) que está sendo herdada com 
        // os parâmetros "base(texto, resposta)".
        public PerguntaPlus(string texto, string resposta, string dica) : base(texto, resposta)
        {
            Dica = dica;
        }
        public string Dica { get; set; }
    }
}
