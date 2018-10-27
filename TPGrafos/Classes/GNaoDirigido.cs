using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrafos.Classes.Estruturas;

namespace TPGrafos.Classes
{
    internal class GNaoDirigido : Grafo
    {
        public GNaoDirigido()
        {

        }
        public GNaoDirigido teste(Stream arquivo)
        {
            return (GNaoDirigido)GeraGrafo(arquivo);
        }
        public GNaoDirigido(ListaVertice vertices, ListaAresta arestas) : base(vertices, arestas)
        {
            this.vertices = vertices;
            this.arestas = arestas;
        }
        //public bool IsAdjacente(Vertice v1, Vertice v2) {
        //}

        public int GetGrau(Vertice v1)
        { return vertices.BuscarVertice(v1).Arestas.Tamanho;}

        public bool IsIsolado(Vertice v1)
        {
            if (GetGrau(v1) == 0)
            { return true; }
            else return false;
        }

        //public bool IsPendente(Vertice v1){}

        //public bool IsRegular(){}

        //public bool IsNulo(){}

        //public bool IsCompleto(){}

        //public bool IsConexo(){}

        //public bool IsEuleriano(){}

        //public bool IsUnicursal(){}

        //public GNaoDirigido GetComplementar(){}

        //public GNaoDirigido GetAGMPrim(Vertice v1){}

        //public GNaoDirigido GetAGMKruscal(Vertice v1){}

        //public int GetCutVertices(){}

    }
}
