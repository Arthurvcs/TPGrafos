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
        string metodo = "";

        public MenuGNaoDirigido(GNaoDirigido g)
        {
            InitializeComponent();
            this.g = g;
            this.StartPosition = FormStartPosition.CenterScreen;
            Vertice[] aux = g.Vertices.GeraVetor();

            for (int i = 0; i < aux.Length; i++)
            {
                this.List_vertices.Items.Add(aux[i].Nome.ToString());
            }

        }
        public MenuGNaoDirigido(GNaoDirigido g, string endereco)
        {
            InitializeComponent();
            this.g = g;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.endereco.Text = endereco;
            this.quant_arestas.Text = g.Arestas.Tamanho.ToString();
            this.quant_vertices.Text = g.Vertices.Tamanho.ToString();
            this.tipo_grafo.Text = "Não dirigido";
            this.btn_geral.Visible = false;

            Vertice[] aux = g.Vertices.GeraVetor();

            for (int i = 0; i < aux.Length; i++)
            {
                this.List_vertices.Items.Add(aux[i].Nome.ToString());
            }
        }

        public GNaoDirigido grafo { get { return this.g; } set { this.g = value; } }

        private void IsAdjacente_Click(object sender, EventArgs e)
        {
            //List_vertices.Visible = true;
            //List_vertices.SelectionMode = SelectionMode.MultiSimple;
            //selecione_label.Text = "Selecione dois vértices";
            //selecione_label.Visible = true;
            //metodo_label.Visible = false;

            //g.IsAdjacente(g.Vertices.Buscar()

        }

        private void btn_geral_Click(object sender, EventArgs e)
        {
            if (metodo == "GETGRAU")
            {
                Vertice aux = new Vertice(Convert.ToInt32(List_vertices.SelectedItem));
                MessageBox.Show("O vértice " + List_vertices.SelectedItem.ToString() + " possui grau: " + g.GetGrau(aux).ToString(), this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (metodo == "ISISOLADO")
            {
                Vertice aux = new Vertice(Convert.ToInt32(List_vertices.SelectedItem));
                if (g.IsIsolado(aux))
                { MessageBox.Show("O vértice é isolado.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                else
                { MessageBox.Show("O vértice não é isolado.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }
            if (metodo == "ISPENDENTE")
            {
                Vertice aux = new Vertice(Convert.ToInt32(List_vertices.SelectedItem));
                if (g.IsPendente(aux))
                { MessageBox.Show("O vértice é pendente.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                else
                { MessageBox.Show("O vértice não é pendente.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }

            List_vertices.Visible = false;
            selecione_label.Visible = false;
            metodo_label.Visible = false;
            this.btn_geral.Visible = false;
            this.btn_geral.Text = "Verificar o grau";
            this.metodo = "";

        }

        private void Get_Grau_Click(object sender, EventArgs e)
        {
            this.metodo = "GETGRAU";
            metodo_label.Visible = false;
            List_vertices.Visible = true;
            selecione_label.Visible = true;
            this.btn_geral.Visible = true;
            this.btn_geral.Text = "Verificar o grau";
            selecione_label.Text = "Selecione o vértice desejado";
        }

        private void Is_isolado_Click(object sender, EventArgs e)
        {
            this.metodo = "ISISOLADO";
            metodo_label.Visible = false;
            List_vertices.Visible = true;
            selecione_label.Visible = true;
            this.btn_geral.Visible = true;
            this.btn_geral.Text = "Verificar o grau";
            selecione_label.Text = "Selecione o vértice desejado";
        }

        private void IsPendente_Click(object sender, EventArgs e)
        {
            this.metodo = "ISPENDENTE";
            metodo_label.Visible = false;
            List_vertices.Visible = true;
            selecione_label.Visible = true;
            this.btn_geral.Visible = true;
            this.btn_geral.Text = "Verificar o grau";
            selecione_label.Text = "Selecione o vértice desejado";
        }

        private void IsRegular_Click(object sender, EventArgs e)
        {
            this.metodo = "ISREGULAR";
            metodo_label.Visible = false;
            List_vertices.Visible = false;
            selecione_label.Visible = false;
            this.btn_geral.Visible = false;
            this.btn_geral.Text = "";
            selecione_label.Text = "";

            Vertice aux = new Vertice(Convert.ToInt32(List_vertices.SelectedItem));
            if (g.IsRegular())
            { MessageBox.Show("O grafo é regular.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            { MessageBox.Show("O grafo não é regular.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }

        private void IsNulo_Click(object sender, EventArgs e)
        {
            this.metodo = "ISNULO";
            metodo_label.Visible = false;
            List_vertices.Visible = false;
            selecione_label.Visible = false;
            this.btn_geral.Visible = false;
            this.btn_geral.Text = "";
            selecione_label.Text = "";

            Vertice aux = new Vertice(Convert.ToInt32(List_vertices.SelectedItem));
            if (g.IsNulo())
            { MessageBox.Show("O grafo é nulo.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            { MessageBox.Show("O grafo não é nulo.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}
