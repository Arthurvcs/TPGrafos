using System;
using System.Windows.Forms;
using TPGrafos.Classes;

namespace TPGrafos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AbirArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog biblioteca = new OpenFileDialog();
            biblioteca.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";


            if (biblioteca.ShowDialog() == DialogResult.OK)
            {
                Grafo g = new Grafo();
                g = g.GetGrafo(biblioteca.OpenFile());

                if (g == null)
                {
                    return;
                }

                if (!g.digrafo)
                {
                    g = (GNaoDirigido)g.GetGrafo(biblioteca.OpenFile());

                    MenuGNaoDirigido MenuGNaoDirigido = new MenuGNaoDirigido((GNaoDirigido)g, biblioteca.FileName);
                    Hide();
                    MenuGNaoDirigido.ShowDialog();
                    Close();
                }
                if (g.digrafo)
                {
                    g = (GDirigido)g.GetGrafo(biblioteca.OpenFile());

                    MenuDigrafo MenuGDirigido = new MenuDigrafo((GDirigido)g, biblioteca.FileName);
                    Hide();
                    MenuGDirigido.ShowDialog();
                    Close();
                }
            }
        }
    }
}


