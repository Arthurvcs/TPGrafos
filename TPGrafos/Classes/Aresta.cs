using TPGrafos.Classes.Estruturas;

namespace TPGrafos.Classes
{
    class Aresta : IDados
    {
        public Aresta(Vertice origem, Vertice destino, int peso)
        {
            Origem = origem;
            Destino = destino;
            Peso = peso;
        }

        public int Peso { get; set; }

        public Vertice Origem { get; set; }

        public Vertice Destino { get; set; }

        public bool Equals(IDados other)
        {
            Vertice aux = (Vertice)other;
            if (Origem.Nome == aux.Nome || Destino.Nome == aux.Nome)
            {
                return true;
            }
            else
                return false;
        }
    }
}
