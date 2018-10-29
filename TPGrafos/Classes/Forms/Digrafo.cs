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
    partial class Digrafo : Form
    {
        private GDirigido g; 

        public Digrafo(GDirigido g)
        {
            InitializeComponent();
            this.g = g;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public GDirigido grafo { get { return this.g; } set { this.g = value; } }


        private void button3_Click_1(object sender, EventArgs e)
        {
            if (this.g.HasCiclo())
            {
                MessageBox.Show("Tem ciclo");
            }
            else
            {
                MessageBox.Show("Não tem ciclo");
            }
        }
    }
}
