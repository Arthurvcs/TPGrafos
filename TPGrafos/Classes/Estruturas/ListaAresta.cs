using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrafos.Classes.Estruturas
{
    class ListaAresta : Lista
    {
        public Aresta[] GeraVetor()
        {
            Aresta[] vetor = new Aresta[this.Tamanho];
            Elemento aux = this.pri.Prox;
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = (Aresta)aux.Dados;
                aux = aux.Prox;
            }
            return vetor;
        }
    }
}
