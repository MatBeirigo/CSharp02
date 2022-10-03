using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Heranca
{
    //Declarando a herança com ":"
    internal class Colaborador : Pessoa
    {

        //Atributos
        private double salario;

        //Construtor
        public Colaborador(string nome, int idade, double salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;

            mensagemPessoa();
            mensagemColaborador();
        }

        //Métodos
        private void mensagemColaborador()
        {
            Console.WriteLine("salário: " + salario);
        }

    }
}
