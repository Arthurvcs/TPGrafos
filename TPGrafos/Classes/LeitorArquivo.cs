using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TPGrafos.Classes
{
    static class LeitorArquivo
    {
        public static string LerArquivo(Stream caminho){

            using (StreamReader reader = new StreamReader(caminho))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
