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

        private void setBoxPosition()
        {
            this.vertices_listBox.Location = new Point(272, 154);
            this.selecione_label.Location = new Point(303, 126);
        }

        public MenuGNaoDirigido(GNaoDirigido g)
        {
            InitializeComponent();
            this.g = g;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.list_vertices_secundaria.Visible = false;

            this.list_vertices_secundaria.Visible = false;
            this.selecione_label_secundaria.Visible = false;

            Vertice[] aux = g.Vertices.GeraVetor();

            for (int i = 0; i < aux.Length; i++)
            {
                this.vertices_listBox.Items.Add(aux[i].Nome.ToString());
            }

        }
        public MenuGNaoDirigido(GNaoDirigido g, string endereco)
        {
            InitializeComponent();
            this.g = g;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.endereco_label.Text = endereco;
            this.quant_arestas_label.Text = g.Arestas.Tamanho.ToString();
            this.quant_vertices_label.Text = g.Vertices.Tamanho.ToString();
            this.tipo_grafo_label.Text = "Não dirigido";
            this.geral_btn.Visible = false;
            Vertice[] aux = g.Vertices.GeraVetor();

            for (int i = 0; i < aux.Length; i++)
            {
                this.vertices_listBox.Items.Add(aux[i].Nome.ToString());
                this.list_vertices_secundaria.Items.Add(aux[i].Nome.ToString());
            }
            this.list_vertices_secundaria.SelectedIndex = 0;
            this.vertices_listBox.SelectedIndex = 0;

        }

        public GNaoDirigido grafo { get { return this.g; } set { this.g = value; } }

        private void IsAdjacente_Click(object sender, EventArgs e)
        {

            this.metodo = "ISADJACENTE";
            //this.vertices_listBox.Location = new Point(188, 154);
            ////this.selecione_label_secundaria.Location = new Point(209, 124);
            //this.selecione_label_secundaria.Visible = true;
            //this.selecione_label.Visible = true;

            //this.metodo_label.Visible = false;

            //this.geral_btn.Visible = true;
            //this.geral_btn.Text = "Verificar";

            //this.list_vertices_secundaria.Visible = true;
            //this.vertices_listBox.Visible = true;
            //this.selecione_label.Visible = true;
            //this.selecione_label_secundaria.Visible = true;
            //this.selecione_label_secundaria.Location = new Point(209, 124);

        }

        private void btn_geral_Click(object sender, EventArgs e)
        {
            if (metodo == "GETGRAU")
            {
                Vertice aux = new Vertice(Convert.ToInt32(vertices_listBox.SelectedItem));
                MessageBox.Show("O vértice " + vertices_listBox.SelectedItem.ToString() + " possui grau: " + g.GetGrau(aux).ToString(), this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (metodo == "ISISOLADO")
            {
                Vertice aux = new Vertice(Convert.ToInt32(vertices_listBox.SelectedItem));
                if (g.IsIsolado(aux))
                { MessageBox.Show("O vértice é isolado.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                else
                { MessageBox.Show("O vértice não é isolado.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            if (metodo == "ISPENDENTE")
            {
                Vertice aux = new Vertice(Convert.ToInt32(vertices_listBox.SelectedItem));
                if (g.IsPendente(aux))
                { MessageBox.Show("O vértice é pendente.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                else
                { MessageBox.Show("O vértice não é pendente.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            if (metodo == "ISADJACENTE")
            {
                Vertice aux = new Vertice(Convert.ToInt32(vertices_listBox.SelectedItem));
                Vertice aux2 = new Vertice(Convert.ToInt32(list_vertices_secundaria.SelectedItem));

                if (g.IsAdjacente(aux, aux2))
                { MessageBox.Show("Os vértices " + vertices_listBox.SelectedItem.ToString() + " e " + list_vertices_secundaria.SelectedItem.ToString() + " são adjacentes", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                else
                { MessageBox.Show("Os vértices " + vertices_listBox.SelectedItem.ToString() + " e " + list_vertices_secundaria.SelectedItem.ToString() + " não são adjacentes", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }

            vertices_listBox.Visible = false;
            list_vertices_secundaria.Visible = false;
            selecione_label_secundaria.Visible = false;
            selecione_label.Visible = false;
            metodo_label.Visible = false;
            this.geral_btn.Visible = false;
            this.geral_btn.Text = "Verificar o grau";
            this.metodo = "";
            this.metodo_label.Visible = true;
        }

        private void Get_Grau_Click(object sender, EventArgs e)
        {
            this.metodo = "GETGRAU";
            HabilitarVizualizacao();
        }

        private void Is_isolado_Click(object sender, EventArgs e)
        {
            this.metodo = "ISISOLADO";
            HabilitarVizualizacao();
        }

        private void IsPendente_Click(object sender, EventArgs e)
        {
            this.metodo = "ISPENDENTE";
            HabilitarVizualizacao();
        }

        private void IsRegular_Click(object sender, EventArgs e)
        {
            this.metodo = "ISREGULAR";
            DesabilitarVizualizacao();

            Vertice aux = new Vertice(Convert.ToInt32(vertices_listBox.SelectedItem));
            if (g.IsRegular())
            { MessageBox.Show("O grafo é regular.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            { MessageBox.Show("O grafo não é regular.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            this.metodo_label.Visible = true;

        }
        /// <summary>
        /// Configuração do botão para verificar se o grafo é nulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsNulo_Click(object sender, EventArgs e)
        {
            this.metodo = "ISNULO";
            DesabilitarVizualizacao();

            if (g.IsNulo())
            { MessageBox.Show("O grafo é nulo.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            { MessageBox.Show("O grafo não é nulo.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            this.metodo_label.Visible = true;
        }
        private void IsCompleto_btn_Click(object sender, EventArgs e)
        {
            this.metodo = "ISCOMPLETO";
            DesabilitarVizualizacao();

            if (g.IsCompleto())
            { MessageBox.Show("O grafo é completo.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            { MessageBox.Show("O grafo não é completo.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            this.metodo_label.Visible = true;
        }

        /// <summary>
        /// Método responsável para habilitar a vizualização dos campos do form atual
        /// </summary>
        private void HabilitarVizualizacao()
        {
            metodo_label.Visible = false;
            vertices_listBox.Visible = true;
            selecione_label.Visible = true;
            this.geral_btn.Visible = true;
            this.geral_btn.Text = "Verificar o grau";
            selecione_label.Text = "Selecione um vértice";
        }
        /// <summary>
        /// Método responsável para limpar o form atual
        /// </summary>
        private void DesabilitarVizualizacao()
        {
            vertices_listBox.Visible = false;
            list_vertices_secundaria.Visible = false;
            selecione_label.Visible = false;
            metodo_label.Visible = false;
            this.geral_btn.Visible = false;
            this.geral_btn.Text = "Verificar o grau";
            this.metodo = "";
            this.metodo_label.Visible = true;
        }
        /// <summary>
        /// Configuração do botão para retornar para tela inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void retona_btn_Click(object sender, EventArgs e)
        {
            Menu main = new Menu();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void GetComplementar_btn_Click(object sender, EventArgs e)
        {
            GNaoDirigido gc = g.GetComplementar();
            string textV = "";
            string textA = "";
            if (gc == g)
            { MessageBox.Show("O grafo não possui complementar, pois já é completo"); }
            else
            {
                Vertice[] aux = gc.Vertices.GeraVetor();
                Aresta[] aux2 = gc.Arestas.GeraVetor();

                for (int i = 0; i < aux.Length; i++)
                { textV += aux[i].Nome + "\n"; }

                for (int i = 0; i < aux2.Length; i++)
                { textA += aux2[i].Origem.Nome.ToString()+ " - " + aux2[i].Destino.Nome.ToString()+ "\n"; }



                MessageBox.Show("O grafo complementar possui: \n" + gc.Vertices.Tamanho + " vértices " +
                       "e " + gc.Arestas.Tamanho + " arestas\n\nOs vértices são:\n" + textV + "\nAs arestas são:\n"+textA);
            }
        }
    }
}
