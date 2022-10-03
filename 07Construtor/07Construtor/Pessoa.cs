using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Construtor
{
    internal class Pessoa
    {

        //Construtor - é executado assim que se instancia um objeto dessa classe, ele sempre é público 

        public Pessoa()
        {
            Console.WriteLine("Construtor executado");
        }

        public Pessoa(string nome)
        {
            Console.WriteLine("Olá " + nome);
        }

    }
}
