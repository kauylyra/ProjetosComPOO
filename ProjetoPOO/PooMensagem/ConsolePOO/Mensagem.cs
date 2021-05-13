using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePOO
{
    public class Mensagem
    {
        //private string TextoMensagem ;
        //public void ExibirMensagem()
        //{
        //    Console.WriteLine(TextoMensagem);
        //}

        //public String getTextoMensagem()
        //{
        //    return TextoMensagem;
        //}

        //public void SetTextoMensagem(string valor)
        //{
        //    TextoMensagem = valor;
        //}

        private string textoMensagem;
        public string TextoMensagem
        {
            get
            {
                return this.textoMensagem;
            }
            set
            {
                this.textoMensagem = value;
            }
        }
        public void ExibirMensagem()
        {
            Console.WriteLine(TextoMensagem);
        }
    }
}
