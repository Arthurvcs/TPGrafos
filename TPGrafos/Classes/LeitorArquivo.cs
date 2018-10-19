using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace TPGrafos.Classes
{
    static class LeitorArquivo
    {
        public static string[] LerArquivo(Stream caminho){

            using (StreamReader reader = new StreamReader(caminho))
            {
                string[] linhas = reader.ReadToEnd().Replace("\r",string.Empty).Split('\n',';');            
                reader.Close(); 
                return linhas;
            }
        }
    }
}
