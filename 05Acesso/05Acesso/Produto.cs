using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Acesso
{
    internal class Produto
    {

        /*
            public     ->  Atributos e métodos visíveis em qualquer classe
            private    ->  Atributos e métodos visíveis apenas na classe onde são criados
            protected  ->    Atributos e métodos visíveis em classes onde são criados ou herdados
         */

        public string nome;
        private double valor; //Somente a classe produto consegue visualizar 

    }
}
