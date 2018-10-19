using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrafos.Classes.Estruturas;

namespace TPGrafos.Classes
{
    class Vertice : IDados
    {
        private int nome { get; set; }
        private int grau { get; set; }
        private Lista arestas;

        public Vertice() { }

        public Vertice(int nome)
        {
            this.nome = nome;
        }

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
