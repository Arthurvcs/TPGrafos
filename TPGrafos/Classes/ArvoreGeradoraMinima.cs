using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrafos.Classes.Estruturas;

namespace TPGrafos.Classes
{
    class ArvoreGeradoraMinima : Grafo
    {

        public ArvoreGeradoraMinima()
        {}
        public ArvoreGeradoraMinima(ListaVertice vertices, ListaAresta arestas) : base(vertices, arestas)
        {
            this.vertices = vertices;
            this.arestas = arestas;
            digrafo = false;
        }
    }
}
