namespace E_Agenda
{
    partial class CompromissoInicialForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVizualizarNormal = new System.Windows.Forms.Button();
            this.btnVoltarTarefa = new System.Windows.Forms.Button();
            this.btnEditarCompromisso = new System.Windows.Forms.Button();
            this.btnExcluirCompromisso = new System.Windows.Forms.Button();
            this.btnCriarCompromisso = new System.Windows.Forms.Button();
            this.tabControlCompromissos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listCompromissosPassados = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.labelTermino = new System.Windows.Forms.Label();
            this.labelInicio = new System.Windows.Forms.Label();
            this.maskedTextTermino = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextInicio = new System.Windows.Forms.MaskedTextBox();
            this.listCompromissosFuturos = new System.Windows.Forms.ListBox();
            this.tabControlCompromissos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "COMPROMISSO";
            // 
            // btnVizualizarNormal
            // 
            this.btnVizualizarNormal.Location = new System.Drawing.Point(12, 277);
            this.btnVizualizarNormal.Name = "btnVizualizarNormal";
            this.btnVizualizarNormal.Size = new System.Drawing.Size(130, 68);
            this.btnVizualizarNormal.TabIndex = 22;
            this.btnVizualizarNormal.Text = "VIZUALIZAR NORMAL";
            this.btnVizualizarNormal.UseVisualStyleBackColor = true;
            this.btnVizualizarNormal.Click += new System.EventHandler(this.btnVizualizarNormal_Click);
            // 
            // btnVoltarTarefa
            // 
            this.btnVoltarTarefa.Location = new System.Drawing.Point(12, 520);
            this.btnVoltarTarefa.Name = "btnVoltarTarefa";
            this.btnVoltarTarefa.Size = new System.Drawing.Size(107, 53);
            this.btnVoltarTarefa.TabIndex = 21;
            this.btnVoltarTarefa.Text = "VOLTAR";
            this.btnVoltarTarefa.UseVisualStyleBackColor = true;
            this.btnVoltarTarefa.Click += new System.EventHandler(this.btnVoltarTarefa_Click);
            // 
            // btnEditarCompromisso
            // 
            this.btnEditarCompromisso.Location = new System.Drawing.Point(12, 203);
            this.btnEditarCompromisso.Name = "btnEditarCompromisso";
            this.btnEditarCompromisso.Size = new System.Drawing.Size(130, 68);
            this.btnEditarCompromisso.TabIndex = 19;
            this.btnEditarCompromisso.Text = "EDITAR";
            this.btnEditarCompromisso.UseVisualStyleBackColor = true;
            this.btnEditarCompromisso.Click += new System.EventHandler(this.btnEditarCompromisso_Click);
            // 
            // btnExcluirCompromisso
            // 
            this.btnExcluirCompromisso.Location = new System.Drawing.Point(12, 129);
            this.btnExcluirCompromisso.Name = "btnExcluirCompromisso";
            this.btnExcluirCompromisso.Size = new System.Drawing.Size(130, 68);
            this.btnExcluirCompromisso.TabIndex = 18;
            this.btnExcluirCompromisso.Text = "EXCLUIR";
            this.btnExcluirCompromisso.UseVisualStyleBackColor = true;
            this.btnExcluirCompromisso.Click += new System.EventHandler(this.btnExcluirCompromisso_Click);
            // 
            // btnCriarCompromisso
            // 
            this.btnCriarCompromisso.Location = new System.Drawing.Point(12, 55);
            this.btnCriarCompromisso.Name = "btnCriarCompromisso";
            this.btnCriarCompromisso.Size = new System.Drawing.Size(130, 68);
            this.btnCriarCompromisso.TabIndex = 16;
            this.btnCriarCompromisso.Text = "CRIAR";
            this.btnCriarCompromisso.UseVisualStyleBackColor = true;
            this.btnCriarCompromisso.Click += new System.EventHandler(this.btnCriarCompromisso_Click);
            // 
            // tabControlCompromissos
            // 
            this.tabControlCompromissos.Controls.Add(this.tabPage1);
            this.tabControlCompromissos.Controls.Add(this.tabPage2);
            this.tabControlCompromissos.Location = new System.Drawing.Point(161, 58);
            this.tabControlCompromissos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlCompromissos.Name = "tabControlCompromissos";
            this.tabControlCompromissos.SelectedIndex = 0;
            this.tabControlCompromissos.Size = new System.Drawing.Size(1217, 547);
            this.tabControlCompromissos.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listCompromissosPassados);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1209, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compromissos passados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listCompromissosPassados
            // 
            this.listCompromissosPassados.FormattingEnabled = true;
            this.listCompromissosPassados.ItemHeight = 25;
            this.listCompromissosPassados.Location = new System.Drawing.Point(4, 10);
            this.listCompromissosPassados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listCompromissosPassados.Name = "listCompromissosPassados";
            this.listCompromissosPassados.Size = new System.Drawing.Size(916, 329);
            this.listCompromissosPassados.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonFiltrar);
            this.tabPage2.Controls.Add(this.labelTermino);
            this.tabPage2.Controls.Add(this.labelInicio);
            this.tabPage2.Controls.Add(this.maskedTextTermino);
            this.tabPage2.Controls.Add(this.maskedTextInicio);
            this.tabPage2.Controls.Add(this.listCompromissosFuturos);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1209, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compromissos futuros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.BackColor = System.Drawing.Color.DimGray;
            this.buttonFiltrar.FlatAppearance.BorderSize = 0;
            this.buttonFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltrar.ForeColor = System.Drawing.Color.White;
            this.buttonFiltrar.Location = new System.Drawing.Point(998, 127);
            this.buttonFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(207, 38);
            this.buttonFiltrar.TabIndex = 14;
            this.buttonFiltrar.Text = "Filtrar por período";
            this.buttonFiltrar.UseVisualStyleBackColor = false;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // labelTermino
            // 
            this.labelTermino.AutoSize = true;
            this.labelTermino.Location = new System.Drawing.Point(973, 89);
            this.labelTermino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTermino.Name = "labelTermino";
            this.labelTermino.Size = new System.Drawing.Size(79, 25);
            this.labelTermino.TabIndex = 15;
            this.labelTermino.Text = "Termino:";
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.Location = new System.Drawing.Point(994, 48);
            this.labelInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(58, 25);
            this.labelInicio.TabIndex = 14;
            this.labelInicio.Text = "Início:";
            // 
            // maskedTextTermino
            // 
            this.maskedTextTermino.Location = new System.Drawing.Point(1064, 86);
            this.maskedTextTermino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextTermino.Mask = "00/00/0000";
            this.maskedTextTermino.Name = "maskedTextTermino";
            this.maskedTextTermino.Size = new System.Drawing.Size(141, 31);
            this.maskedTextTermino.TabIndex = 3;
            this.maskedTextTermino.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextInicio
            // 
            this.maskedTextInicio.Location = new System.Drawing.Point(1060, 45);
            this.maskedTextInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextInicio.Mask = "00/00/0000";
            this.maskedTextInicio.Name = "maskedTextInicio";
            this.maskedTextInicio.Size = new System.Drawing.Size(141, 31);
            this.maskedTextInicio.TabIndex = 2;
            this.maskedTextInicio.ValidatingType = typeof(System.DateTime);
            // 
            // listCompromissosFuturos
            // 
            this.listCompromissosFuturos.FormattingEnabled = true;
            this.listCompromissosFuturos.ItemHeight = 25;
            this.listCompromissosFuturos.Location = new System.Drawing.Point(7, 12);
            this.listCompromissosFuturos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listCompromissosFuturos.Name = "listCompromissosFuturos";
            this.listCompromissosFuturos.Size = new System.Drawing.Size(1206, 579);
            this.listCompromissosFuturos.TabIndex = 1;
            // 
            // CompromissoInicialForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 676);
            this.Controls.Add(this.tabControlCompromissos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVizualizarNormal);
            this.Controls.Add(this.btnVoltarTarefa);
            this.Controls.Add(this.btnEditarCompromisso);
            this.Controls.Add(this.btnExcluirCompromisso);
            this.Controls.Add(this.btnCriarCompromisso);
            this.Name = "CompromissoInicialForms";
            this.Text = "CompromissoInicialForms";
            this.tabControlCompromissos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVizualizarNormal;
        private System.Windows.Forms.Button btnVoltarTarefa;
        private System.Windows.Forms.Button btnEditarCompromisso;
        private System.Windows.Forms.Button btnExcluirCompromisso;
        private System.Windows.Forms.Button btnCriarCompromisso;
        private System.Windows.Forms.TabControl tabControlCompromissos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listCompromissosPassados;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Label labelTermino;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.MaskedTextBox maskedTextTermino;
        private System.Windows.Forms.MaskedTextBox maskedTextInicio;
        private System.Windows.Forms.ListBox listCompromissosFuturos;
    }
}