using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrafos.Classes.Estruturas;

namespace TPGrafos.Classes
{
    class Vertice
    {
        private int nome { get; set; }
        private int grau { get; set; }
        private ListaArestas arestas;

        public int Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public int Grau
        {
            get { return this.grau; }
            set { this.grau = value; }
        }
    }
}
