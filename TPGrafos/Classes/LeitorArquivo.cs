using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TPGrafos.Classes.Estruturas;
using System.Text.RegularExpressions;
using TPGrafos.Classes;

namespace TPGrafos.Classes
{
    static class LeitorArquivo
    {
        /// <summary>
        /// Método para relizar a leitura do arquivo que o usuário informou
        /// </summary>
        /// <param name="caminho">O arquivo que o usuário vai informar</param>
        /// <returns>uma linha contendo as informações do arquivo</returns>
        public static string LerArquivo(Stream caminho)
        {
            using (StreamReader leitor = new StreamReader(caminho))
            {
                string linhas = leitor.ReadToEnd();
                leitor.Close();
                return linhas;
            }
        }

        /// <summary>
        /// Método para realizar tratamento do arquivo
        /// </summary>
        /// <param name="arquivo">o arquivo informado pelo usuário</param>
        /// <returns>Um array com os posições referentes ao arquivo</returns>
        public static string[] FormatarArquivo(string arquivo)
        {
            string[] linhas = arquivo.Replace("\r", "").Split('\n',';');
            return linhas;          
        }
    }
}

