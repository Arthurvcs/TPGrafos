using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrafos.Classes.Estruturas
{
    class ListaVertice : Lista
    {
        public Vertice BuscarVertice(Vertice v) { return (Vertice)Buscar(v); }


        public void BuscarAdicionarOrigem(Aresta a)
        {
            Vertice auxOrigem = (Vertice)Buscar(a.Origem);

            if (auxOrigem != null)
            { a.Origem.Arestas.Adicionar(a); }
        }

        public void BuscarAdicionarDestino(Aresta a)
        {
            Vertice auxDestino = (Vertice)Buscar(a.Destino);

            if (auxDestino != null)
            { a.Destino.Arestas.Adicionar(a); }
        }
        public void GerarLista(int tamanho)
        {
            for (int i = 0; i < tamanho; i++)
            {
                var aux = new Vertice();
                Adicionar(aux);
                aux.Nome = i + 1;
            }
        }
        public Vertice[] GeraVetor()
        {
            Vertice[] vetor = new Vertice[this.Tamanho];
            Elemento aux = this.pri.Prox;
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = (Vertice)aux.Dados;
                aux = aux.Prox;
            }
            return vetor;
        }

    }
}
