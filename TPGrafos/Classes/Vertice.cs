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
        private ListaAresta arestas;

        public Vertice() { this.arestas = new ListaAresta(); }

        public Vertice(int nome)
        {
            this.nome = nome;
            this.arestas = new ListaAresta();
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

        public ListaAresta Arestas {
            get { return this.arestas; }
            set { this.arestas = value; }
        }

        public bool Equals(IDados other)
        {
            Vertice aux = (Vertice)other;
            if (this.nome == aux.nome)
            {
                return true;
            }
            else
                return false;
        }
    }
}
