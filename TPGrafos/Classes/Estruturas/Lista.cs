using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrafos.Classes.Estruturas
{
    class Lista
    {
        public Elemento pri, ult;

        public Lista()
        {
            this.pri = new Elemento(null);//"sentinela"
            this.ult = pri;
            this.Tamanho = 0;
        }

        public void Adicionar(IDados d)
        {
            Elemento aux = new Elemento(d);
            this.ult.Prox = aux; //Referenciando a posição final a partir do último elemento
            this.ult = aux;// O ultimo elemento é o elemento adicionado
            Tamanho++;
        }

        public virtual IDados Buscar(IDados d)
        {
            Elemento aux = this.pri.Prox;
            while (aux != null)
            {
                if (aux.Dados.Equals(d))
                {
                    return aux.Dados;
                }
                else
                    aux = aux.Prox;
            }
            return null;
        }
        public int Tamanho { get; set; }
    }
}
