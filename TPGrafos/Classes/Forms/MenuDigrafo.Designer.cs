﻿namespace TPGrafos
{
    partial class MenuDigrafo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDigrafo));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.HasCiclo_btn = new System.Windows.Forms.Button();
            this.GetGrauSaida_btn = new System.Windows.Forms.Button();
            this.GetGrauEntrada_btn = new System.Windows.Forms.Button();
            this.vertices_listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.retorna_btn = new System.Windows.Forms.Button();
            this.quant_arestas_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.quant_vertices_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tipo_grafo_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selecione_label = new System.Windows.Forms.Label();
            this.metodo_label = new System.Windows.Forms.Label();
            this.endereco_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.geral_btn = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.HasCiclo_btn);
            this.MainPanel.Controls.Add(this.GetGrauSaida_btn);
            this.MainPanel.Controls.Add(this.GetGrauEntrada_btn);
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.Name = "MainPanel";
            // 
            // HasCiclo_btn
            // 
            this.HasCiclo_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HasCiclo_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.HasCiclo_btn, "HasCiclo_btn");
            this.HasCiclo_btn.Name = "HasCiclo_btn";
            this.HasCiclo_btn.UseVisualStyleBackColor = false;
            this.HasCiclo_btn.Click += new System.EventHandler(this.HasCiclo_btn_Click);
            // 
            // GetGrauSaida_btn
            // 
            this.GetGrauSaida_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GetGrauSaida_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.GetGrauSaida_btn, "GetGrauSaida_btn");
            this.GetGrauSaida_btn.Name = "GetGrauSaida_btn";
            this.GetGrauSaida_btn.UseVisualStyleBackColor = false;
            this.GetGrauSaida_btn.Click += new System.EventHandler(this.GetGrauSaida_btn_Click);
            // 
            // GetGrauEntrada_btn
            // 
            this.GetGrauEntrada_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GetGrauEntrada_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.GetGrauEntrada_btn, "GetGrauEntrada_btn");
            this.GetGrauEntrada_btn.Name = "GetGrauEntrada_btn";
            this.GetGrauEntrada_btn.UseVisualStyleBackColor = false;
            this.GetGrauEntrada_btn.Click += new System.EventHandler(this.GetGrauEntrada_btn_Click);
            // 
            // vertices_listBox
            // 
            resources.ApplyResources(this.vertices_listBox, "vertices_listBox");
            this.vertices_listBox.FormattingEnabled = true;
            this.vertices_listBox.Name = "vertices_listBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // retorna_btn
            // 
            this.retorna_btn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.retorna_btn, "retorna_btn");
            this.retorna_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retorna_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.retorna_btn.FlatAppearance.BorderSize = 0;
            this.retorna_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.retorna_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.retorna_btn.Name = "retorna_btn";
            this.retorna_btn.UseVisualStyleBackColor = false;
            this.retorna_btn.Click += new System.EventHandler(this.retorna_btn_Click);
            // 
            // quant_arestas_label
            // 
            resources.ApplyResources(this.quant_arestas_label, "quant_arestas_label");
            this.quant_arestas_label.Name = "quant_arestas_label";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // quant_vertices_label
            // 
            resources.ApplyResources(this.quant_vertices_label, "quant_vertices_label");
            this.quant_vertices_label.Name = "quant_vertices_label";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // tipo_grafo_label
            // 
            resources.ApplyResources(this.tipo_grafo_label, "tipo_grafo_label");
            this.tipo_grafo_label.Name = "tipo_grafo_label";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // selecione_label
            // 
            resources.ApplyResources(this.selecione_label, "selecione_label");
            this.selecione_label.Name = "selecione_label";
            // 
            // metodo_label
            // 
            resources.ApplyResources(this.metodo_label, "metodo_label");
            this.metodo_label.Name = "metodo_label";
            // 
            // endereco_label
            // 
            resources.ApplyResources(this.endereco_label, "endereco_label");
            this.endereco_label.Name = "endereco_label";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // geral_btn
            // 
            this.geral_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.geral_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.geral_btn, "geral_btn");
            this.geral_btn.Name = "geral_btn";
            this.geral_btn.UseVisualStyleBackColor = false;
            this.geral_btn.Click += new System.EventHandler(this.geral_btn_Click);
            // 
            // MenuDigrafo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.geral_btn);
            this.Controls.Add(this.endereco_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metodo_label);
            this.Controls.Add(this.selecione_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.retorna_btn);
            this.Controls.Add(this.quant_arestas_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quant_vertices_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tipo_grafo_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vertices_listBox);
            this.Controls.Add(this.MainPanel);
            this.Name = "MenuDigrafo";
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button GetGrauSaida_btn;
        private System.Windows.Forms.Button GetGrauEntrada_btn;
        private System.Windows.Forms.Button HasCiclo_btn;
        private System.Windows.Forms.ListBox vertices_listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button retorna_btn;
        private System.Windows.Forms.Label quant_arestas_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label quant_vertices_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tipo_grafo_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label selecione_label;
        private System.Windows.Forms.Label metodo_label;
        private System.Windows.Forms.Label endereco_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button geral_btn;
    }
}