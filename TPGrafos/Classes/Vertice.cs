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

        public static explicit operator Vertice(Elemento v)
        {
            throw new NotImplementedException();
        }

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

        public Lista Arestas {
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
