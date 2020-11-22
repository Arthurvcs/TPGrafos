namespace TPGrafos.Classes.Estruturas
{
    class Lista
    {
        public Elemento pri, ult;

        public Lista()
        {
            pri = new Elemento(null);//"sentinela"
            ult = pri;
            Tamanho = 0;
        }

        public void Adicionar(IDados d)
        {
            Elemento aux = new Elemento(d);
            ult.Prox = aux; //Referenciando a posição final a partir do último elemento
            ult = aux;// O ultimo elemento é o elemento adicionado
            Tamanho++;
        }

        public virtual IDados Buscar(IDados d)
        {
            Elemento aux = pri.Prox;
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
