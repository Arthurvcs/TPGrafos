using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrafos.Classes.Estruturas;

namespace TPGrafos.Classes
{
    class Aresta : IDados
    {
        private int peso;
        private Vertice vOrigem;
        private Vertice vDestino;

        public Aresta(Vertice origem, Vertice destino, int peso)
        {
            this.vOrigem = origem;
            this.vDestino = destino;
            this.peso = peso;
        }

        public int Peso
        {
            get { return this.peso; }
            set { this.peso = value; }
        }

        public Vertice Origem
        {
            get { return this.vOrigem; }
            set { this.vOrigem = value; }
        }

        public Vertice Destino
        {
            get { return this.vDestino; }
            set { this.vDestino = value; }
        }

        public bool Equals(IDados other)
        {
            throw new NotImplementedException();
        }
    }
}
