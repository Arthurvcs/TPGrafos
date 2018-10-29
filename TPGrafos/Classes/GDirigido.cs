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
        public GDirigido()
        {
        }

        //public override Grafo GetGrafo(Stream arquivo)
        //{
        //    return (GDirigido)GeraGrafo(arquivo);
        //}
        public GDirigido(ListaVertice vertices, ListaAresta arestas) : base(vertices, arestas)
        {
            this.vertices = vertices;
            this.arestas = arestas;
        }

        public GDirigido(ListaVertice vertices, ListaAresta arestas, bool _digrafo) : base(vertices, arestas, _digrafo)
        {
            this.vertices = vertices;
            this.arestas = arestas;
            this.digrafo = _digrafo;
        }

        /// <summary>
        /// Conta a quantidade de arestas que tem como destino o vértice informado por parâmetro
        /// </summary>
        /// <param name="v1">vértice informado pelo usuário</param>
        /// <returns>
        /// Grau de entrada do vértice informado
        /// </returns>
        public int GetGrauEntrada(Vertice v1)
        {
            int grauEntrada = 0;

            Elemento aux = v1.Arestas.pri.Prox; //busca o primeiro elemento da lista de arestas do vértice informado por parâmetro

            while (aux != null)
            {
                Aresta auxA = (Aresta)aux.Dados;

                if (auxA.Destino.Equals(v1)) //se o vertice de destino da aresta atual é igual ao vertice informado 
                {
                    grauEntrada++; //aumenta o valor do grau de entrada do vertice a ser retornado
                    aux = aux.Prox;
                }
                else
                    aux = aux.Prox; //parte para o proximo elemento
            }

            return grauEntrada;
        }

        /// <summary>
        /// Conta a quantidade de arestas que tem como origem o vértice informado por parâmetro
        /// </summary>
        /// <param name="v1">vértice informado pelo usuário</param>
        /// <returns>
        /// Grau de saída do vértice informado
        /// </returns>
        public int GetGrauSaida(Vertice v1)
        {
            int grauSaida = 0;

            Elemento aux = v1.Arestas.pri.Prox; //busca o primeiro elemento da lista de arestas do vértice informado por parâmetro

            while (aux != null)
            {
                Aresta auxA = (Aresta)aux.Dados;

                if (auxA.Origem.Equals(v1)) //se o vertice de origem da aresta atual é igual ao vertice informado 
                {
                    grauSaida++; //aumenta o valor do grau de saída do vertice a ser retornado
                    aux = aux.Prox;
                }
                else
                    aux = aux.Prox; //parte para o proximo elemento
            }

            return grauSaida;
        }

        public struct Vertex
        {
            public Vertice vertice;
            public int cor;
        }

        public bool HasCiclo()
        {
            Elemento vStart = this.vertices.pri.Prox;

            int[] visitados = new int[this.vertices.Tamanho];
            int visitaCount = 0;

            Elemento auxV = this.vertices.pri.Prox;

            //for (int i = 0; i <= visitados.Length; i++)
            //{
            //    visitados[i].vertice = (Vertice)auxV.Dados;
            //    visitados[i].cor = 1;

            //    auxV = auxV.Prox;
            //}

            auxV = vStart;
            int fimBusca = 0;
            Vertice auxVx = (Vertice)auxV.Dados;

            //for (int i = 0; i < vertexes.Length; i++)
            //{

            //}

            while (fimBusca == 0)
            {
                if (GetGrauEntrada(auxVx) != 1) //se o grau de entrada não for 1, significa que não existe um ciclo, pois não existe aresta chegando ao vertice ou existem mais de uma aresta chegando ao vertice
                {
                    fimBusca = 1; //indica que a busca pelo ciclo terminou
                    break;
                }
                else if (GetGrauSaida(auxVx) != 1) //se o grau de saida não for 1, significa que não existe um ciclo, pois não existe aresta saindo do vertice ou existem mais de uma aresta saindo do vertice
                {
                    fimBusca = 1; //indica que a busca pelo ciclo terminou
                    break;
                }

                Elemento AuxAr = auxVx.Arestas.pri.Prox;
                Aresta auxA = (Aresta)AuxAr.Dados;

                if (auxA.Origem.Equals(auxVx))
                {
                    if (visitados.Contains(auxA.Destino.Nome))
                    {
                        if ((visitaCount+1) == visitados.Length && auxA.Destino.Equals((Vertice)vStart.Dados))
                        {
                            return true;
                        }
                        else
                        {
                            fimBusca = 1; //indica que a busca pelo ciclo terminou
                            break;
                        }
                    }
                    else
                    {
                        visitados[visitaCount] = auxVx.Nome;
                        visitaCount++;
                        auxVx = auxA.Destino;
                    }

                }
                else
                {
                    auxA = (Aresta)AuxAr.Prox.Dados;

                    if (visitados.Contains(auxA.Destino.Nome))
                    {
                        if ((visitaCount + 1) == visitados.Length && auxA.Destino.Equals((Vertice)vStart.Dados))
                        {
                            return true;
                        }
                        else
                        {
                            fimBusca = 1; //indica que a busca pelo ciclo terminou
                            break;
                        }
                    }
                    else
                    {
                        visitados[visitaCount] = auxVx.Nome;
                        visitaCount++;
                        auxVx = auxA.Destino;
                    }
                }
            }

            if (fimBusca == 1)
            {
                return false;
            }
            else return true;
        }
    }
}
