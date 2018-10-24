using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrafos.Classes.Estruturas
{
    class ListaVertice : Lista
    {
        public Vertice Buscar(int nome)
        {
            Vertice aux = (Vertice)this.pri.Prox;

            while (aux != null)
            {
                if (aux.Nome.Equals(nome))
                {
                    return aux;
                }
                else
                    aux = aux.Prox;
                return null;
            }
            return null;
        }

        public override IDados Buscar(IDados d)
        {
            Elemento aux = this.pri.Prox;
            while (aux != null)
            {
                if (aux.Nome.Equals(d))
                {
                    return aux;
                }
                else
                    aux = aux.;
            }
            return null;
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
    }
}
