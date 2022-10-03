using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09This
{
    internal class Pessoa
    {

        //Atributo
        private string nome = "Tatiana";

        //Construtor 
        public Pessoa(string nome)
        {
            //Aqui o que passamos é um parâmetro
            Console.WriteLine(nome);
            //O this liga o atributo da classe ao seu método
            Console.WriteLine(this.nome);
        }

    }
}
