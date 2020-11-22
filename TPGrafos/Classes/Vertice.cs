using System.Linq;
using TPGrafos.Classes.Estruturas;

namespace TPGrafos.Classes
{
    class Vertice : IDados
    {
        private int nome { get; set; }
        private int grau { get; set; }

        public Vertice() { Arestas = new ListaAresta();
            Cor = "BRANCO";
        }

        public Vertice(int nome)
        {
            this.nome = nome;
            Cor = "BRANCO";
            Arestas = new ListaAresta();
        }

        public int Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Grau
        {
            get { return grau; }
            set { grau = value; }
        }

        public string Cor { get; set; }

        public ListaAresta Arestas { get; set; }

        public Vertice[] GetAdjacentes()
        {
            Elemento aux = Arestas.pri.Prox;
            Vertice[] adj = new Vertice[Arestas.Tamanho];
            int pos = 0;

            while(aux != null)
            {
                Aresta auxA = (Aresta)aux.Dados;

                if (auxA.Origem.Nome == nome && adj.Contains(auxA.Destino) == false)
                {
                    adj[pos] = auxA.Destino;
                    pos++;
                    aux = aux.Prox;
                }
                else if (auxA.Destino.Nome == nome && adj.Contains(auxA.Origem) == false)
                {
                    adj[pos] = auxA.Origem;
                    pos++;
                    aux = aux.Prox;
                }
                else { aux = aux.Prox; }
            }
            return adj;
        }

        public void AtualizaCor()
        {
            if(Cor == "BRANCO")
            { Cor = "CINZA"; }

            else if(Cor == "CINZA")
            { Cor = "PRETO"; }
        }

        public bool Equals(IDados other)
        {
            Vertice aux = (Vertice)other;
            if (nome == aux.nome)
            {
                return true;
            }
            else
                return false;
        }
    }
}
