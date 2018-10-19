using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPGrafos.Classes;
using System.IO;
using TPGrafos.Classes.Estruturas;

namespace TPGrafos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbirArquivo_Click(object sender, EventArgs e)
        {
            string[] conteudo;
            ListaAresta aresta = new ListaAresta();
            ListaVertice vertice = new ListaVertice();

            OpenFileDialog biblioteca = new OpenFileDialog();
            biblioteca.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (biblioteca.ShowDialog() == DialogResult.OK){
                conteudo = LeitorArquivo.LerArquivo(biblioteca.OpenFile());

                for (int i = 0; i < conteudo.Length; i++)
                {
                    vertice.GerarLista(int.Parse(conteudo[0]));
                    aresta.Adicionar(new Aresta(new Vertice(int.Parse(conteudo[1])), new Vertice(int.Parse(conteudo[2])), int.Parse(conteudo[3])));
                }

                MessageBox.Show("show");
            }
        }
    }
    }

