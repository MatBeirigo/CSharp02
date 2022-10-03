using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Encapsulamento
{
    internal class Aluno
    {
        //Atributos
        private double nota1, nota2;

        //Método média
        private double media()
        {
            return (nota1 + nota2) / 2;
        }

        //Mensagem
        public void mensagem()
        {
            Console.WriteLine("Informe a primeira nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A média é " + media());
        }
    
        /*
            O conceito de encapsulamento é justamente restringir o acesso a informação que tem nas classes, priorizando apenas os dados mais importantes para o código
         */

    }
}
