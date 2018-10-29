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
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AbirArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog biblioteca = new OpenFileDialog();
            biblioteca.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (biblioteca.ShowDialog() == DialogResult.OK)
            {
                Grafo g = new Grafo();
                g = g.GetGrafo(biblioteca.OpenFile());

                if (g.digrafo == false)
                {

                    g = (GNaoDirigido)g.GetGrafo(biblioteca.OpenFile());
                    
                    MenuGNaoDirigido MenuGNaoDirigido = new MenuGNaoDirigido((GNaoDirigido)g, biblioteca.FileName);
                    this.Hide();
                    MenuGNaoDirigido.ShowDialog();
                    this.Close();
                }
                else
                {
                    g = (GDirigido)g.GetGrafo(biblioteca.OpenFile());

                    MenuDigrafo MenuGDirigido = new MenuDigrafo((GDirigido)g,biblioteca.FileName);
                    this.Hide();
                    MenuGDirigido.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
    

