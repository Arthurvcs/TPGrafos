using System;

namespace TPGrafos.Classes.Estruturas
{
    class Elemento:IDados
    {
        public Elemento(IDados dados)
        {
            Prox = null;
            Dados = dados;
        }

        public Elemento Prox { get; set; }

        public IDados Dados { get; set; }

        public bool Equals(IDados other)
        {
            throw new NotImplementedException();
        }
    }
}
