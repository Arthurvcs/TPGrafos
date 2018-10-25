using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrafos.Classes.Estruturas
{
    class ListaVertice : Lista
    {
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
