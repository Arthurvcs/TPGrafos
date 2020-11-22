namespace TPGrafos.Classes.Estruturas
{
    class ListaAresta : Lista
    {
        public Aresta[] GeraVetor()//Gerar um vetor com todas as arestas do grafo
        {
            Aresta[] vetor = new Aresta[Tamanho];
            Elemento aux = pri.Prox;
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = (Aresta)aux.Dados;
                aux = aux.Prox;
            }
            return vetor;
        }
        public Aresta[] Ordenar(Aresta[] vet)
        {
            int tamanho = vet.Length;
            Aresta temp = vet[0];

            for (int i = 0; i < tamanho; i++)
            {
                for (int j = i + 1; j < tamanho; j++)
                {
                    if (vet[i].Peso > vet[j].Peso)
                    {
                        temp = vet[i];
                        vet[i] = vet[j];
                        vet[j] = temp;
                    }
                }
            }
            return vet;
        }
    }
}
