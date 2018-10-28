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
using TPGrafos.Classes.Estruturas;

namespace TPGrafos
{
    partial class MenuGNaoDirigido : Form
    {
        private GNaoDirigido g;

        public MenuGNaoDirigido(GNaoDirigido g)
        {
            InitializeComponent();
            this.g = g;
            this.StartPosition = FormStartPosition.CenterScreen;
            Vertice[] aux = g.Vertices.GeraVetor();

            for(int i = 0; i< aux.Length;i++)
            {
                this.List_vertices.Items.Add(aux[i].Nome.ToString());
            }
        }
        public MenuGNaoDirigido(GNaoDirigido g,string endereco)
        {
            InitializeComponent();
            this.g = g;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.endereco.Text = endereco;
            this.quant_arestas.Text = g.Arestas.Tamanho.ToString();
            this.quant_vertices.Text = g.Vertices.Tamanho.ToString();
            this.tipo_grafo.Text = "Não dirigido";

            Vertice[] aux = g.Vertices.GeraVetor();

            for (int i = 0; i < aux.Length; i++)
            {
                this.List_vertices.Items.Add(aux[i].Nome);
            }
        }

        public GNaoDirigido grafo { get { return this.g; } set { this.g = value; } }
    }
}
