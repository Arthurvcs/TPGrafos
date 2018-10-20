using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TPGrafos.Classes.Estruturas;
using System.Text.RegularExpressions;


namespace TPGrafos.Classes
{
     class LeitorArquivo
    {
        /// <summary>
        /// Método para verificar a segunda linha do arquivo (onde consta a info se é ou não direcionado)
        /// </summary>
        /// <param name="caminho">Arquivo informado pelo usuário</param>
        /// <returns>Um vetor com a segunda linha do arquivo</returns>
        private static string[] LeituraPreliminar(Stream caminho)
        {
            using (StreamReader reader = new StreamReader(caminho))
            {
                string[] linhas = LeituraCompleta(caminho);//.Replace("\r", string.Empty).Split('\n', 
                linhas = linhas[1].Replace("\r", "").Split('\n', ';');
                reader.Close();
                return linhas;
            }
        }

        /// <summary>
        /// Método para realizar a leitura e tratar o arquivo
        /// </summary>
        /// <param name="caminho">o arquivo que o usuário vai informar</param>
        /// <returns>Um array com os posições referentes ao arquivo</returns>
        private static string[] LeituraCompleta(Stream caminho)
        {
            using (StreamReader reader = new StreamReader(caminho))
            {
                string[] linhas = reader.ReadToEnd().Replace("\r", "").Split('\n', ';');
                reader.Close();
                return linhas;
            }
        }

        /// <summary>
        /// Método para verificar se o grafo é orientado
        /// </summary>
        /// <param name="caminho">arquivo informado pelo usuário</param>
        /// <returns>
        /// True: É orientado 
        /// False: não é orientado
        /// </returns>
        public static bool IsDigrafo(Stream caminho)
        {
            var aux = LeituraPreliminar(caminho);
            if (aux.Length == 3) { return true; }
            else { return false; }
        }

        public static Grafo GeraGrafo(Stream caminho)
        {
            ListaAresta arestas = new ListaAresta();
            ListaVertice vertices = new ListaVertice();
            string[] info = LeituraCompleta(caminho);
            Grafo g;

            //é orientado
            if (IsDigrafo(caminho))
            {
                //teste de retorno
                return g = new Grafo(arestas, vertices);
            }
            else //Não é orientado
            {
                vertices.GerarLista(int.Parse(info[0]));
                for (int i = 1; i < info.Length; i++)
                {
                    arestas.Adicionar(new Aresta(new Vertice(int.Parse(info[i])), new Vertice(int.Parse(info[i + 1])), int.Parse(info[i + 2])));
                }

                g = new GNaoDirigido(vertices, arestas);
                return g;
            }
        }
    }
}
