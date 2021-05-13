using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
   
    public enum TipoAnimal { Cachorro, Gato, Peixe };
    public class Animal
    {
        public Animal(string nome, TipoAnimal tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }
        public Animal()
        {
        }
        public string Nome { get; private set; }
        public TipoAnimal Tipo { get; private set; }

        public TipoAnimal SetTipo(TipoAnimal tipo) //valores definidos pelo usuário - cachorro, gato, peixe
        {
            Tipo = tipo;
            return Tipo;
        }

        public string SetNome(string nome)
        {
            Nome = nome;
            return Nome;
        }
    }
}
