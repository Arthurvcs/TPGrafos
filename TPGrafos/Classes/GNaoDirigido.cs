using System;
using System.Collections.Generic;
using TPGrafos.Classes.Estruturas;

namespace TPGrafos.Classes
{
    class GNaoDirigido : Grafo
    {
        private int componentes;// variável usada para verificar quantas componetes conexas um grafo possui
        public GNaoDirigido() { }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="vertices">Lista de vértices</param>
        /// <param name="arestas">Lista de arestas</param>
        public GNaoDirigido(ListaVertice vertices, ListaAresta arestas) : base(vertices, arestas)
        {
            this.vertices = vertices;
            this.arestas = arestas;
            digrafo = false;
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
            { return false; }
        }

        /// <summary>
        /// Método que verifica o grau de um determinado vértice
        /// </summary>
        /// <param name="v1">Vértice informado pelo usuário</param>
        /// <returns>O grau de um determinado vértice</returns>
        public int GetGrau(Vertice v1)
        { return vertices.BuscarVertice(v1).Arestas.Tamanho; }

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
        public bool IsPendente(Vertice v1)
        {
            if (GetGrau(v1) == 1)
            { return true; }
            else return false;
        }

        /// <summary>
        /// Um grafo no qual todos os vértices possuem o mesmo grau é chamado de grafo regular
        /// </summary>
        /// <returns></returns>
        public bool IsRegular()
        {

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
        public bool IsNulo()
        {
            Elemento auxE = vertices.pri.Prox;
            while (auxE.Prox != null)
            {
                if (IsIsolado((Vertice)auxE.Dados) == false)
                { return false; }
                auxE = auxE.Prox;
            }
            return true;
        }

        /// <summary>
        /// Um grafo é dito completo se para cada par de vertices existe uma aresta
        /// </summary>
        /// <returns>
        /// true: o grafo é completo
        /// false: o grafo não é completo
        /// </returns>
        public bool IsCompleto()
        {
            //verificando o primeiro teorema 
            //O número de arestas de um grafo completo é n(n-1)/2 
            int teorema = (vertices.Tamanho * (vertices.Tamanho - 1)) / 2;
            if (Arestas.Tamanho == teorema)//Verificar se o teorema atende as condições
            {
                int pos = 0;
                Vertice[] aux = vertices.GeraVetor();

                while (pos < aux.Length)
                {
                    for (int i = 0; i < aux.Length - 1; i++)
                    {
                        if (!IsAdjacente(aux[pos], aux[i + 1]))
                        {
                            return false;
                        }
                    }
                    pos++;
                }
                return true;
            }
            else
                return false;
        }

        /// <summary>
        ///  Um Grafo é dito conexo caso exista pelo menos um caminho entre todos os pares de vértices de G
        /// </summary>
        /// <returns>
        /// true: é conexo
        /// false: não é conexo
        /// </returns>
        public bool IsConexo()
        {
            componentes = GetComponentes();//Verifica quantas componentes conexas possuem no grafo
            Elemento aux = vertices.pri.Prox;

            while (aux != null)// Verificar se não há vértices de cor branca (caso tenha algum vértice nulo)
            {
                if (vertices.BuscarVertice((Vertice)aux.Dados).Cor == "BRANCO")
                { componentes++; }
                aux = aux.Prox;
            }

            if (componentes > 1) // Se o grafo possuir mais de uma componente conexa, ele é desconexo
            { return false; }

            else
            { return true; }
        }

        /// <summary>
        /// Um grafo conexo, não orientado é euleriano se, e somente se, todos os seus vértices tiverem grau par
        /// </summary>
        /// <returns>
        /// true: é Euleriano
        /// False: não é Euleriano
        /// </returns>
        public bool IsEuleriano()
        {
            if (IsConexo())
            {
                Elemento aux = vertices.pri.Prox;
                while (aux.Prox != null)
                {
                    if (vertices.BuscarVertice((Vertice)aux.Dados).Arestas.Tamanho % 2 != 0)
                    { return false; }
                    aux = aux.Prox;
                }
                return false;
            }
            else
            { return false; }
        }

        /// <summary>
        ///Em um grafo conexo G com exatamente 2K vértices de grau ímpar, existem K subgrafos disjuntos de arestas, todos eles unicursais, de maneira que juntos eles contêm todas as arestas de G
        /// </summary>
        /// <returns>
        /// true : É Unicursal
        /// False: Não é unicursal
        /// </returns>
        public bool IsUnicursal()
        {
            int Impar = 0;
            Elemento aux = vertices.pri.Prox;
            while (aux.Prox != null)
            {
                if (vertices.BuscarVertice((Vertice)aux.Dados).Arestas.Tamanho % 2 != 0)
                {
                    Impar++;
                    if (Impar > 1)//se ele possuir mais de um vértice com grau par
                    { return true; }
                }
                aux = aux.Prox;
            }
            return false;
        }

        /// <summary>
        /// Um grafo complementar é um grafo resultante de outro grafo, um grafo complementar possui vértices e arestas necessárias para tornar um grafo completo
        /// </summary>
        /// <returns>Um grafo complementar</returns>
        public GNaoDirigido GetComplementar()
        {
            GNaoDirigido Gcomplementar;
            ListaVertice verticesAux = new ListaVertice();
            ListaAresta arestasAux = new ListaAresta();

            if (IsCompleto())
            { return this; }

            else
            {
                int pos = 0;
                Vertice[] aux = vertices.GeraVetor();

                while (pos < aux.Length)
                {
                    for (int i = 0; i < aux.Length - 1; i++)
                    {
                        if (!IsAdjacente(aux[pos], aux[i + 1]))// Comparando os vértices e verificando se há adjacência entre eles
                        {
                            Vertice clone = new Vertice(aux[pos].Nome);
                            Vertice clone2 = new Vertice(aux[i + 1].Nome);

                            if (verticesAux.BuscarVertice(clone) != null)
                            { clone = (Vertice)verticesAux.Buscar(clone); }

                            if (verticesAux.BuscarVertice(clone2) != null)
                            { clone2 = (Vertice)verticesAux.Buscar(clone2); }

                            Aresta auxA = new Aresta(clone, clone2, 0);

                            arestasAux.Adicionar(auxA);

                            if (verticesAux.BuscarVertice(clone) == null)
                            { verticesAux.Adicionar(clone); }

                            clone.Arestas.Adicionar(auxA);

                            if (verticesAux.BuscarVertice(clone2) == null)
                            { verticesAux.Adicionar(clone2); }

                            clone2.Arestas.Adicionar(auxA);

                            vertices.BuscarVertice(clone).Arestas.Adicionar(auxA);
                            vertices.BuscarVertice(clone2).Arestas.Adicionar(auxA);
                        }
                    }
                    pos++;
                }
                Gcomplementar = new GNaoDirigido(verticesAux, arestasAux);
                return Gcomplementar;
            }
        }

        /// <summary>
        /// Método recursivo para simular o algortimo de busca em profundidade
        /// </summary>
        /// <param name="v">Vertice para ser analisado</param>
        private void Visitar(Vertice v)
        {
            Vertices.BuscarVertice(v).AtualizaCor();
            foreach (Vertice v2 in v.GetAdjacentes())
            {
                if (v2.Cor == "BRANCO")
                { Visitar(v2); }
            }
            v.AtualizaCor();
        }

        /// <summary>
        /// Método para limpar as cores do grafo, para o algoritmo de busca em profundidade
        /// </summary>
        private void ResetarCores()
        {
            Elemento aux = vertices.pri.Prox;
            while (aux.Prox != null)
            {
                vertices.BuscarVertice((Vertice)aux.Dados).Cor = "BRANCO";
                aux = aux.Prox;
            }
        }

        /// <summary>
        /// Método para verificar quantas componentes conexas o grafo possui
        /// </summary>
        /// <returns>O número total de componentes conexas de um grafo</returns>
        private int GetComponentes()
        {
            int componentes = 0;
            ResetarCores();

            Elemento aux = vertices.pri.Prox;
            while (aux.Prox != null)
            {
                if (vertices.BuscarVertice((Vertice)aux.Dados).Cor == "BRANCO")
                {
                    Visitar(vertices.BuscarVertice((Vertice)aux.Dados));
                    componentes++;
                }
                aux = aux.Prox;
            }

            return componentes;

        }
    }
}
