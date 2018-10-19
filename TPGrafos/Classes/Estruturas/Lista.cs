using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrafos.Classes.Estruturas
{
    class Lista
    {
        private Elemento pri, ult;

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

        public int Tamanho { get; set; }
    }
}
