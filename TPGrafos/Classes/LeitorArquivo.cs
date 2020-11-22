using System;
using System.IO;
using System.Windows.Forms;

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
            try
            {
                string[] linhas = arquivo.Replace("\r", "").Split('\n', ';');
                return linhas;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro", "O arquivo informado está em um formato incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Correção", "O arquivo deve seguir esse padrão: (Exemplo)\n3\n1; 2; 7\n1; 3; 3\n2; 3; 10");
                return null;
            }
        }
    }
}

