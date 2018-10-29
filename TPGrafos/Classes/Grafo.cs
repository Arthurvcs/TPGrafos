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
        protected ListaVertice vertices;
        protected ListaAresta arestas;
        public bool digrafo;

        public Grafo()
        { }

        public virtual Grafo GetGrafo(Stream arquivo)
        {
            return GeraGrafo(arquivo);
        }

        public Grafo(ListaVertice vertices, ListaAresta arestas)
        {
            this.vertices = vertices;
            this.arestas = arestas;
        }

        public Grafo(ListaVertice vertices, ListaAresta arestas, bool _digrafo)
        {
            this.vertices = vertices;
            this.arestas = arestas;
            this.digrafo = _digrafo;
        }

        /// <summary>
        /// Método para verificar se o grafo é orientado
        /// </summary>
        /// <param name="arquivo">arquivo informado pelo usuário</param>
        /// <returns>
        /// True: É orientado 
        /// False: não é orientado
        /// </returns>
        private void IsDigrafo(string arquivo)
        {
            string[] linhas = arquivo.Replace("\r", "").Split('\n');
            if (linhas.Length == 1)
            { this.digrafo = false; }
            linhas = linhas[1].Replace("\r", "").Split('\n', ';');

            if (linhas.Length == 3) { this.digrafo = false; }
            else { this.digrafo = true; }
        }

        /// <summary>
        /// Método para gerar o grafo
        /// </summary>
        /// <param name="caminho">o arquivo que o usuário informa</param>
        /// <returns>Retorna um grafo</returns>
        protected Grafo GeraGrafo(Stream caminho)
        {
            Grafo g;
            ListaVertice vertices = new ListaVertice();
            ListaAresta arestas = new ListaAresta();

            string arquivo = LeitorArquivo.LerArquivo(caminho);//As linhas do arquivos sem tratamento
            string[] infoGrafo = LeitorArquivo.FormatarArquivo(arquivo);// Vetor com o arquivo tratado
            string[] linhasArquivo = arquivo.Replace("\r", "").Split('\n');//Vetor com as linhas do arquivo (utilizada no for para gerar o grafo)

            this.IsDigrafo(arquivo);

            //é orientado
            if (digrafo)
            {
                g = new GDirigido();

                vertices.GerarLista(int.Parse(infoGrafo[0]));

                for (int i = 1; i < infoGrafo.Length; i = i + 4)
                {
                    //Lista de arestas

                    Aresta auxA;

                    if (int.Parse(infoGrafo[i + 3]) == 1) //Se a aresta tem direção 1, cria a aresta com origem e destino na sequencia informada
                    {
                        Vertice auxVo = vertices.BuscarVertice(new Vertice(Convert.ToInt32(infoGrafo[i])));
                        Vertice auxVd = vertices.BuscarVertice(new Vertice(Convert.ToInt32(infoGrafo[i + 1])));


                        auxA = new Aresta(auxVo, auxVd, int.Parse(infoGrafo[i + 2]));
                        arestas.Adicionar(auxA);
                    }
                    else //se não, cria a aresta com origem e destino na direção inversa
                    {
                        Vertice auxVo = vertices.BuscarVertice(new Vertice(Convert.ToInt32(infoGrafo[i + 1])));
                        Vertice auxVd = vertices.BuscarVertice(new Vertice(Convert.ToInt32(infoGrafo[i])));


                        auxA = new Aresta(auxVo, auxVd, int.Parse(infoGrafo[i + 2]));
                        arestas.Adicionar(auxA);
                    }


                    if (vertices.Buscar(auxA.Origem) == null)
                    {
                        vertices.Adicionar(auxA.Origem);
                        vertices.BuscarAdicionarOrigem(auxA);
                    }
                    else
                    { vertices.BuscarVertice(auxA.Origem).Arestas.Adicionar(auxA); }

                    if (vertices.Buscar(auxA.Destino) == null)
                    {
                        vertices.Adicionar(auxA.Destino);
                        vertices.BuscarAdicionarDestino(auxA);
                    }
                    else
                    { vertices.BuscarVertice(auxA.Destino).Arestas.Adicionar(auxA); }
                }
                return g = new GDirigido(vertices, arestas, this.digrafo);
            }
            else //Não é orientado
            {
                g = new GNaoDirigido();

                vertices.GerarLista(int.Parse(infoGrafo[0]));

                for (int i = 1; i < infoGrafo.Length; i = i + 3)
                {
                    //Lista de arestas

                    Vertice auxVo = vertices.BuscarVertice(new Vertice(Convert.ToInt32(infoGrafo[i])));
                    Vertice auxVd = vertices.BuscarVertice(new Vertice(Convert.ToInt32(infoGrafo[i + 1])));


                    Aresta auxA = new Aresta(auxVo, auxVd, int.Parse(infoGrafo[i + 2]));
                    arestas.Adicionar(auxA);

                    if (vertices.Buscar(auxA.Origem) == null)
                    {
                        vertices.Adicionar(auxA.Origem);
                        vertices.BuscarAdicionarOrigem(auxA);
                    }
                    else
                    { vertices.BuscarVertice(auxA.Origem).Arestas.Adicionar(auxA); }

                    if (vertices.Buscar(auxA.Destino) == null)
                    {
                        vertices.Adicionar(auxA.Destino);
                        vertices.BuscarAdicionarDestino(auxA);
                    }
                    else
                    { vertices.BuscarVertice(auxA.Destino).Arestas.Adicionar(auxA); }
                }
                return g = new GNaoDirigido(vertices, arestas, this.digrafo);
            }
        }

        public ListaVertice Vertices
        {
            get { return this.vertices; }
            set { this.vertices = value; }
        }

        public ListaAresta Arestas
        {
            get { return this.arestas; }
            set { this.arestas = value; }
        }
    }
}
