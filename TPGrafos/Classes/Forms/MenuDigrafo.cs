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
        private GDirigido g; /*{ get { return this.g; } set { this.g = value; } }*/
        string metodo = "";

        public MenuDigrafo(GDirigido g, string endereco)
        {
            InitializeComponent();
            this.g = g;
            Vertice[] aux = g.Vertices.GeraVetor();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.endereco_label.Text = endereco;
            this.quant_arestas_label.Text = g.Arestas.Tamanho.ToString();
            this.quant_vertices_label.Text = g.Vertices.Tamanho.ToString();
            this.tipo_grafo_label.Text = "Digrafo";
            this.geral_btn.Visible = false;

            for (int i = 0; i < aux.Length; i++)//Preenchendo a listBox com os nomes dos vértices
            {
                this.vertices_listBox.Items.Add(aux[i].Nome.ToString());
            }
        }
        /// <summary>
        /// Configuração do botão para resolução dos métodos que envolvem algum tipo de seleção do lado do usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void geral_btn_Click(object sender, EventArgs e)
        {
            if (metodo == "GETGRAUENTRADA")
            {
                Vertice aux = new Vertice(Convert.ToInt32(vertices_listBox.SelectedItem));
                MessageBox.Show("O vértice " + vertices_listBox.SelectedItem.ToString() + " possui grau de entrada: " + g.GetGrauEntrada(aux).ToString(), this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (metodo == "GETGRAUSAIDA")
            {
                Vertice aux = new Vertice(Convert.ToInt32(vertices_listBox.SelectedItem));
                MessageBox.Show("O vértice " + vertices_listBox.SelectedItem.ToString() + " possui grau de saída: " + g.GetGrauSaida(aux).ToString(), this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            DesabilitarVizualizacao();
        }
        /// <summary>
        /// Configuração do botão para verificar o grau de entrada de um determinado vértice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetGrauEntrada_btn_Click(object sender, EventArgs e)
        {
            this.metodo = "GETGRAUENTRADA";
            this.HabilitarVizualizacao();
        }
        /// <summary>
        /// Configuração do botão para verificar o grau de saida de um determinado vértice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetGrauSaida_btn_Click(object sender, EventArgs e)
        {
            this.metodo = "GETGRAUSAIDA";
            this.HabilitarVizualizacao();
        }
        /// <summary>
        /// Configuração do botão para verificar se um grafo possui ciclo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HasCiclo_btn_Click(object sender, EventArgs e)
        {
            this.metodo = "HASCICLO";
            DesabilitarVizualizacao();

            Vertice aux = new Vertice(Convert.ToInt32(vertices_listBox.SelectedItem));
            if (g.HasCiclo())
            { MessageBox.Show("O grafo possui ciclo.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            { MessageBox.Show("O grafo não possui ciclo.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
            selecione_label.Text = "Selecione o vértice desejado";
        }
        /// <summary>
        /// Método responsável para limpar o form atual
        /// </summary>
        private void DesabilitarVizualizacao()
        {
            vertices_listBox.Visible = false;
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
        private void retorna_btn_Click(object sender, EventArgs e)
        {
            Menu main = new Menu();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
    }
}

