using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrafos.Classes.Estruturas;

namespace TPGrafos.Classes
{
    class Grafo
    {
        protected ListaAresta vertices;
        protected ListaVertice arestas;

        public Grafo(Stream arquivo)
        {
            GeraGrafo(arquivo);
        }
        public Grafo(ListaAresta vertices, ListaVertice arestas)
        {
            this.vertices = vertices;
            this.arestas = arestas;
        }

        /// <summary>
        /// Método para verificar se o grafo é orientado
        /// </summary>
        /// <param name="arquivo">arquivo informado pelo usuário</param>
        /// <returns>
        /// True: É orientado 
        /// False: não é orientado
        /// </returns>
        private static bool IsDigrafo(string arquivo)
        {
            string[] linhas = arquivo.Replace("\r", "").Split('\n');
            linhas = linhas[1].Replace("\r", "").Split('\n', ';');

            if (linhas.Length == 3) { return false; }
            else { return true; }
        }

        /// <summary>
        /// Método para gerar o grafo
        /// </summary>
        /// <param name="caminho">o arquivo que o usuário informa</param>
        /// <returns>Retorna um grafo</returns>
        private static Grafo GeraGrafo(Stream caminho)
        {
            Grafo g;


            string arquivo = LeitorArquivo.LerArquivo(caminho);//As linhas do arquivos sem tratamento
            string[] infoGrafo = LeitorArquivo.FormatarArquivo(arquivo);// Vetor com o arquivo tratado
            string[] linhasArquivo = arquivo.Replace("\r", "").Split('\n');//Vetor com as linhas do arquivo (utilizada no for para gerar o grafo)

            //é orientado
            if (IsDigrafo(arquivo))
            {
                //teste de retorno
                return g = new Grafo(arestas, vertices);
            }
            else //Não é orientado
            {
                for (int i = 1; i < infoGrafo.Length; i = i + 3)
                {
                    //Lista de arestas
                    Aresta auxA = new Aresta(new Vertice(int.Parse(infoGrafo[i])), new Vertice(int.Parse(infoGrafo[i + 1])), int.Parse(infoGrafo[i + 2]));
                    arestas.Adicionar(auxA);

                    if (vertices.Buscar(auxA.Origem) == null)
                    {
                        vertices.Adicionar(auxA.Origem);
                        vertices.BuscarAdicionarOrigem(auxA);
                    }
                    else
                    {vertices.BuscarVertice(auxA.Origem).Arestas.Adicionar(auxA);}

                    if (vertices.Buscar(auxA.Destino) == null)
                    {
                        vertices.Adicionar(auxA.Destino);
                        vertices.BuscarAdicionarDestino(auxA);
                    }
                    else
                    { vertices.BuscarVertice(auxA.Destino).Arestas.Adicionar(auxA); }
                }
                return g = new GNaoDirigido(vertices, arestas);
            }
        }

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
