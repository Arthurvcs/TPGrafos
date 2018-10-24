using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrafos.Classes.Estruturas
{
    class Elemento:IDados
    {
        private Elemento prox;
        private IDados dados;

        public Elemento(IDados dados)
        {
            this.prox = null;
            this.dados = dados;
        }

        public Elemento Prox
        {
            get { return this.prox; }
            set { this.prox = value; }
        }

        public IDados Dados
        {
            get { return this.dados; }
            set { this.dados = value; }
        }

        public bool Equals(IDados other)
        {
            throw new NotImplementedException();
        }
    }
}
