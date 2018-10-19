using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrafos.Classes.Estruturas;

namespace TPGrafos.Classes
{
    class Grafo
    {
        protected Lista vertices;
        protected Lista arestas;

        public Lista Vertice
        {
            get { return this.vertices; }
            set { this.vertices = value; }
        }

        public Lista Aresta
        {
            get { return this.arestas; }
            set { this.arestas = value; }
        }
    }
}
