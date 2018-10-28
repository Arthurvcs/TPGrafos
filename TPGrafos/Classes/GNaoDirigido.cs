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
        public GNaoDirigido(){}

        //public GNaoDirigido Grafo(Stream arquivo)
        //{
        //    return (GNaoDirigido)GeraGrafo(arquivo);
        //}
        public GNaoDirigido(ListaVertice vertices, ListaAresta arestas) : base(vertices, arestas)
        {
            this.vertices = vertices;
            this.arestas = arestas;
        }

        /// <summary>
        /// Um vertice é adjacente a outro caso haja uma aresta que o liga com outro vértice
        /// </summary>
        /// <param name="v1">vértice informado pelo usuário</param>
        /// <param name="v2">vértice informado pelo usuário</param>
        /// <returns>
        /// true: é adjacente
        /// false: não é adjacente
        /// </returns>
        public bool IsAdjacente(Vertice v1, Vertice v2)
        {
            if (vertices.BuscarVertice(v1).Arestas.Buscar(v2) != null)
            { return true; }
            else
                return false;
        }

        /// <summary>
        /// Método que verifica o grau de um determinado vértice
        /// </summary>
        /// <param name="v1">Vértice informado pelo usuário</param>
        /// <returns>O grau de um determinado vértice</returns>
        public int GetGrau(Vertice v1)
        { return vertices.BuscarVertice(v1).Arestas.Tamanho;}

        /// <summary>
        /// Um vértice é considerado isolado, caso seu grau seja igual a 0
        /// </summary>
        /// <param name="v1">vértice informado pelo usuário</param>
        /// <returns>
        /// true: é isolado
        /// false: Não é isolado
        /// </returns>
        public bool IsIsolado(Vertice v1)
        {
            if (GetGrau(v1) == 0)
            { return true; }
            else return false;
        }

        /// <summary>
        /// Um vértice é considerado pendente, caso seu grau seja igual a 1.
        /// </summary>
        /// <param name="v1">vértice informado pelo usuário</param>
        /// <returns>
        /// true: é pendente
        /// false: não é pendente
        /// </returns>
        public bool IsPendente(Vertice v1) {
            if (GetGrau(v1) == 1)
            { return true; }
            else return false;
        }
        /// <summary>
        /// Um grafo no qual todos os vértices possuem o mesmo grau é chamado de grafo regular
        /// </summary>
        /// <returns></returns>
        public bool IsRegular() {

            Elemento auxE = vertices.pri.Prox;
            while (auxE.Prox != null)
            {
                if (vertices.BuscarVertice((Vertice)auxE.Dados).Arestas.Tamanho != vertices.BuscarVertice((Vertice)auxE.Prox.Dados).Arestas.Tamanho)
                { return false; }
                auxE = auxE.Prox;
            }
            return true;
        }

        /// <summary>
        /// Grafos que possuem somente vértices isolados são chamados de grafos nulos
        /// </summary>
        /// <returns>
        /// true: O grafo é nulo
        /// False: O grafo não é nulo
        /// </returns>
        public bool IsNulo(){

            Elemento auxE = vertices.pri.Prox;
            while (auxE.Prox != null)
            {
                if (IsIsolado((Vertice)auxE.Dados)== false)
                { return false; }               
                auxE = auxE.Prox;
            }
            return true;
        }

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
