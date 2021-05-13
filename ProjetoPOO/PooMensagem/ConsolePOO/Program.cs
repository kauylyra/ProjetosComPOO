using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem mensagem = new Mensagem();
            mensagem.TextoMensagem = "Alô Mundo";
            mensagem.ExibirMensagem();

            //Mensagem mensagem2 = new Mensagem();
            //mensagem2.SetTextoMensagem("Segundo Objeto");
            //mensagem2.ExibirMensagem();

            Console.ReadKey(); //sempre espera o usuário pressionar qualquer tecla para fechar;
        }
    }
}
