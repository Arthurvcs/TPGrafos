using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrafos.Classes.Estruturas;

namespace TPGrafos.Classes
{
    internal class GDirigido : Grafo
    {
        public  GDirigido()
        {
        }

        public override Grafo GetGrafo(Stream arquivo)
        {
            return (GNaoDirigido)GeraGrafo(arquivo);
        }
        public GDirigido(ListaVertice vertices, ListaAresta arestas):base(vertices,arestas)
        {
            this.vertices = vertices;
            this.arestas = arestas;
        }

       
        //public int GetGrauEntrada(Vertice v1){}

        //public int GetGrauEntrada(Vertice v1){}

        //public bool HasCiclo(){}
    }
}
