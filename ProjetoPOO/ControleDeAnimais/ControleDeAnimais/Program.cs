using System;

namespace ControleDeAnimais
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal;
            int tamLogico = 0;     // Tamanho lógico (Quantidade de elementos guardados nele);
            Animal[] animais = new Animal[20]; // criando um Array que vai armazenar objetos do tipo ANIMAL ( posso colocar 1 animal em cada Array até 20 vezes);

            int tpCachorro = 0; int tpGato = 0; int tpPeixe = 0;
            int tipoAnimal = 0;
            Console.WriteLine("Controle de Animais.");

            //Leitura da quantidade de animais;
            try
            {
                Console.WriteLine("informe quantos animais deseja inserir, no máximo 20.");
                tamLogico = int.Parse(Console.ReadLine());
                if (tamLogico > 20) tamLogico = 20;
            }
            catch
            {
                tamLogico = 0;
            }
            for (int i = 0; i < tamLogico; i++)
            {
                animal = new Animal();
                Console.WriteLine("Informe o nome do " + (i + 1) + "° animal: ");
                animal.SetNome(Console.ReadLine());
                Console.WriteLine("Informe qual o tipo do " + (i + 1) + "° animal(Cachorro - 0, Gato - 1 ou Peixe - 2): ");
                try
                {
                    tipoAnimal = int.Parse(Console.ReadLine());
                    if (tipoAnimal < 0 || tipoAnimal > 2) tipoAnimal = 2;// se o numero que o usuário digitou for menor que 0 ou maior que 2 sempre vai ser peixe.

                }
                catch
                {
                    tipoAnimal = 2;
                }
                if (tipoAnimal == 0) animal.SetTipo(TipoAnimal.Cachorro);
                if (tipoAnimal == 1) animal.SetTipo(TipoAnimal.Gato);
                if (tipoAnimal == 2) animal.SetTipo(TipoAnimal.Peixe);

                //CONTANDO O TIPO INFORMADO;
                if (tipoAnimal == 0) tpCachorro++;
                if (tipoAnimal == 1) tpGato++;
                if (tipoAnimal == 2) tpPeixe++;
                //Armazenar o animal do Vetor;
                animais[i] = animal;
            }
            //Resultado
            Console.WriteLine("Total de Animais: ");
            Console.WriteLine("Cachorros : " + tpCachorro + "\nGatos : " + tpGato + "\nPeixes : " + tpPeixe);
            Console.ReadKey();
        }
    }
}
