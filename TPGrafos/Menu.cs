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
            OpenFileDialog biblioteca = new OpenFileDialog();
            biblioteca.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (biblioteca.ShowDialog() == DialogResult.OK)
            {
                Grafo teste;
                teste = LeitorArquivo.GeraGrafo(biblioteca.OpenFile());
            }
            MessageBox.Show("show");
        }
    }
}
    

