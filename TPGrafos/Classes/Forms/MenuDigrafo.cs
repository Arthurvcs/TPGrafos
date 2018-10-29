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

namespace TPGrafos
{
    partial class MenuDigrafo : Form
    {
        private GDirigido g;
        string metodo = "";

        public MenuDigrafo(GDirigido g)
        {
            InitializeComponent();
            this.g = g;
            this.StartPosition = FormStartPosition.CenterScreen;
            Vertice[] aux = g.Vertices.GeraVetor();

            for (int i = 0; i < aux.Length; i++)
            {
                this.vertices_listBox.Items.Add(aux[i].Nome.ToString());
            }
        }

        public MenuDigrafo(GDirigido g, string endereco)
        {
            InitializeComponent();
            this.g = g;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.endereco_label.Text = endereco;
            this.quant_arestas_label.Text = g.Arestas.Tamanho.ToString();
            this.quant_vertices_label.Text = g.Vertices.Tamanho.ToString();
            this.tipo_grafo_label.Text = "Digrafo";
            this.geral_btn.Visible = false;

            Vertice[] aux = g.Vertices.GeraVetor();

            for (int i = 0; i < aux.Length; i++)
            {
                this.vertices_listBox.Items.Add(aux[i].Nome.ToString());
            }
        }

        public GDirigido grafo { get { return this.g; } set { this.g = value; } }

        private void HasCiclo_btn_Click(object sender, EventArgs e)
        {
            this.metodo = "HASCICLO";
            metodo_label.Visible = false;
            vertices_listBox.Visible = false;
            selecione_label.Visible = false;
            this.geral_btn.Visible = false;
            this.geral_btn.Text = "";
            selecione_label.Text = "";

            Vertice aux = new Vertice(Convert.ToInt32(vertices_listBox.SelectedItem));
            if (g.HasCiclo())
            { MessageBox.Show("O grafo possui ciclo.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            { MessageBox.Show("O grafo não possui ciclo.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            this.metodo_label.Visible = true;
        }
    }
}
