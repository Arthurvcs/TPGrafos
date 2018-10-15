﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            string conteudo;
            OpenFileDialog biblioteca = new OpenFileDialog();
            biblioteca.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (biblioteca.ShowDialog() == DialogResult.OK){
                var arq = biblioteca.OpenFile();
           
                using (StreamReader reader = new StreamReader(arq)){
                    conteudo = reader.ReadToEnd();
                }
                MessageBox.Show(conteudo);
            }
        }
    }
}
