using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Acesso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            //Não tem acesso ao p.valor
            p.nome = "Café";
        }
    }
}
