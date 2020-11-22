using System;
using System.Drawing;
using System.Windows.Forms;
using TPGrafos.Classes;

namespace TPGrafos
{
    partial class MenuGNaoDirigido : Form
    {
        string metodo = "";

        private void setBoxPosition()
        {
            vertices_listBox.Location = new Point(272, 154);
            selecione_label.Location = new Point(303, 126);
        }

        public MenuGNaoDirigido(GNaoDirigido g)
        {
            InitializeComponent();
            grafo = g;
            StartPosition = FormStartPosition.CenterScreen;
            list_vertices_secundaria.Visible = false;

            list_vertices_secundaria.Visible = false;
            selecione_label_secundaria.Visible = false;

            Vertice[] aux = g.Vertices.GeraVetor();

            for (int i = 0; i < aux.Length; i++)
            {
                vertices_listBox.Items.Add(aux[i].Nome.ToString());
            }

        }
        public MenuGNaoDirigido(GNaoDirigido g, string endereco)
        {
            InitializeComponent();
            grafo = g;
            StartPosition = FormStartPosition.CenterScreen;
            endereco_label.Text = endereco;
            quant_arestas_label.Text = g.Arestas.Tamanho.ToString();
            quant_vertices_label.Text = g.Vertices.Tamanho.ToString();
            tipo_grafo_label.Text = "Não dirigido";
            geral_btn.Visible = false;
            Vertice[] aux = g.Vertices.GeraVetor();

            for (int i = 0; i < aux.Length; i++)
            {
                vertices_listBox.Items.Add(aux[i].Nome.ToString());
                list_vertices_secundaria.Items.Add(aux[i].Nome.ToString());
            }
            list_vertices_secundaria.SelectedIndex = 0;
            vertices_listBox.SelectedIndex = 0;

        }

        private void IsAdjacente_Click(object sender, EventArgs e)
        {
            metodo = "ISADJACENTE";
            geral_btn.Text = "verificar o grau";
            vertices_listBox.Location = new Point(188, 154);
            vertices_listBox.Visible = true;
            metodo_label.Visible = false;
            selecione_label.Visible = true;
            selecione_label.Location = new Point(209, 124);
            selecione_label_secundaria.Visible = true;
            list_vertices_secundaria.Visible = true;
            geral_btn.Visible = true;
        }

        private void btn_geral_Click(object sender, EventArgs e)
        {
            if (metodo == "GETGRAU")
            {
                Vertice aux = new Vertice(Convert.ToInt32(vertices_listBox.SelectedItem));
                MessageBox.Show("O vértice " + vertices_listBox.SelectedItem.ToString() + " possui grau: " + grafo.GetGrau(aux).ToString(), this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (metodo == "ISISOLADO")
            {
                Vertice aux = new Vertice(Convert.ToInt32(vertices_listBox.SelectedItem));
                if (grafo.IsIsolado(aux))
                { MessageBox.Show("O vértice é isolado.", metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                else
                { MessageBox.Show("O vértice não é isolado.", metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            if (metodo == "ISPENDENTE")
            {
                Vertice aux = new Vertice(Convert.ToInt32(vertices_listBox.SelectedItem));
                if (grafo.IsPendente(aux))
                { MessageBox.Show("O vértice é pendente.", metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                else
                { MessageBox.Show("O vértice não é pendente.", metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            if (metodo == "ISADJACENTE")
            {
                Vertice aux = new Vertice(Convert.ToInt32(vertices_listBox.SelectedItem));
                Vertice aux2 = new Vertice(Convert.ToInt32(list_vertices_secundaria.SelectedItem));

                if (grafo.IsAdjacente(aux, aux2))
                { MessageBox.Show("Os vértices " + vertices_listBox.SelectedItem.ToString() + " e " + list_vertices_secundaria.SelectedItem.ToString() + " são adjacentes", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                else
                { MessageBox.Show("Os vértices " + vertices_listBox.SelectedItem.ToString() + " e " + list_vertices_secundaria.SelectedItem.ToString() + " não são adjacentes", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                vertices_listBox.Location = new Point(282, 154);
                selecione_label.Location = new Point(312, 124);
            }

            vertices_listBox.Visible = false;
            list_vertices_secundaria.Visible = false;
            selecione_label_secundaria.Visible = false;
            selecione_label.Visible = false;
            metodo_label.Visible = false;
            geral_btn.Visible = false;
            metodo = "";
            metodo_label.Visible = true;
        }

        private void Get_Grau_Click(object sender, EventArgs e)
        {
            metodo = "GETGRAU";
            HabilitarVizualizacao();
        }

        private void Is_isolado_Click(object sender, EventArgs e)
        {
            metodo = "ISISOLADO";
            HabilitarVizualizacao();
        }

        private void IsPendente_Click(object sender, EventArgs e)
        {
            metodo = "ISPENDENTE";
            HabilitarVizualizacao();
        }

        private void IsRegular_Click(object sender, EventArgs e)
        {
            metodo = "ISREGULAR";
            DesabilitarVizualizacao();

            Vertice aux = new Vertice(Convert.ToInt32(vertices_listBox.SelectedItem));
            if (grafo.IsRegular())
            { MessageBox.Show("O grafo é regular.", metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            { MessageBox.Show("O grafo não é regular.", metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            metodo_label.Visible = true;

        }
        /// <summary>
        /// Configuração do botão para verificar se o grafo é nulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsNulo_Click(object sender, EventArgs e)
        {
            metodo = "ISNULO";
            DesabilitarVizualizacao();

            if (grafo.IsNulo())
            { MessageBox.Show("O grafo é nulo.", metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            { MessageBox.Show("O grafo não é nulo.", metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            metodo_label.Visible = true;
        }
        private void IsCompleto_btn_Click(object sender, EventArgs e)
        {
            metodo = "ISCOMPLETO";
            DesabilitarVizualizacao();

            if (grafo.IsCompleto())
            { MessageBox.Show("O grafo é completo.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            { MessageBox.Show("O grafo não é completo.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            metodo_label.Visible = true;
        }

        private void IsConexo_btn_Click(object sender, EventArgs e)
        {
            metodo = "ISCONEXO";
            DesabilitarVizualizacao();

            if (grafo.IsConexo())
            { MessageBox.Show("O grafo é conexo.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            { MessageBox.Show("O grafo não é conexo.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            metodo_label.Visible = true;
        }

        private void IsEuleriano_btn_Click(object sender, EventArgs e)
        {
            this.metodo = "ISEULERIANO";
            DesabilitarVizualizacao();

            if (grafo.IsEuleriano())
            { MessageBox.Show("O grafo é Euleriano.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            { MessageBox.Show("O grafo não é Euleriano.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            metodo_label.Visible = true;
        }

        private void IsUnicursal_btn_Click(object sender, EventArgs e)
        {
            metodo = "ISUNICURSAL";
            DesabilitarVizualizacao();

            if (grafo.IsUnicursal())
            { MessageBox.Show("O grafo é unicursal.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            { MessageBox.Show("O grafo não é unicursal.", this.metodo, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            metodo_label.Visible = true;
        }

        /// <summary>
        /// Método responsável para habilitar a vizualização dos campos do form atual
        /// </summary>
        private void HabilitarVizualizacao()
        {
            metodo_label.Visible = false;
            vertices_listBox.Visible = true;
            selecione_label.Visible = true;
            geral_btn.Visible = true;
            geral_btn.Text = "Verificar o grau";
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
            geral_btn.Visible = false;
            geral_btn.Text = "Verificar o grau";
            metodo = "";
            metodo_label.Visible = true;
        }
        /// <summary>
        /// Configuração do botão para retornar para tela inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void retona_btn_Click(object sender, EventArgs e)
        {
            Menu main = new Menu();
            Hide();
            main.ShowDialog();
            Close();
        }

        private void GetComplementar_btn_Click(object sender, EventArgs e)
        {
            GNaoDirigido gc = grafo.GetComplementar();
            string textV = "";
            string textA = "";
            if (gc == grafo)
            { MessageBox.Show("O grafo não possui complementar, pois já é completo", metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            {
                Vertice[] aux = gc.Vertices.GeraVetor();
                Aresta[] aux2 = gc.Arestas.GeraVetor();

                for (int i = 0; i < aux.Length; i++)
                { textV += aux[i].Nome + "\n"; }

                for (int i = 0; i < aux2.Length; i++)
                { textA += aux2[i].Origem.Nome.ToString() + " - " + aux2[i].Destino.Nome.ToString() + "\n"; }



                MessageBox.Show("O grafo complementar possui: \n" + gc.Vertices.Tamanho + " vértices " +
                       "e " + gc.Arestas.Tamanho + " arestas\n\nOs vértices são:\n" + textV + "\nAs arestas são:\n" + textA, metodo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        public GNaoDirigido grafo { get; set; }

        private void GetAGMPrim_btn_Click(object sender, EventArgs e)
        {

        }

        private void GetAGMKruskal_btn_Click(object sender, EventArgs e)
        {
            metodo = "GETAGMPRIM ";
            DesabilitarVizualizacao();

            GNaoDirigido GRetorno = grafo;



            metodo_label.Visible = true;
        }
    }
}
