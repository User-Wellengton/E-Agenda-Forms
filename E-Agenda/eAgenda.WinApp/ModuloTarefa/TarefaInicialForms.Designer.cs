namespace E_Agenda
{
    partial class TarefaInicialForms
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
            this.btnCriarTarefa = new System.Windows.Forms.Button();
            this.btnExcluirTarefa = new System.Windows.Forms.Button();
            this.btnEditarTarefa = new System.Windows.Forms.Button();
            this.btnVoltarTarefa = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.btnConcluirItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listTarefasPendentes = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listTarefasConcluidas = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCriarTarefa
            // 
            this.btnCriarTarefa.Location = new System.Drawing.Point(12, 46);
            this.btnCriarTarefa.Name = "btnCriarTarefa";
            this.btnCriarTarefa.Size = new System.Drawing.Size(130, 68);
            this.btnCriarTarefa.TabIndex = 0;
            this.btnCriarTarefa.Text = "CRIAR";
            this.btnCriarTarefa.UseVisualStyleBackColor = true;
            this.btnCriarTarefa.Click += new System.EventHandler(this.btnCriarTarefa_Click);
            // 
            // btnExcluirTarefa
            // 
            this.btnExcluirTarefa.Location = new System.Drawing.Point(12, 120);
            this.btnExcluirTarefa.Name = "btnExcluirTarefa";
            this.btnExcluirTarefa.Size = new System.Drawing.Size(130, 68);
            this.btnExcluirTarefa.TabIndex = 2;
            this.btnExcluirTarefa.Text = "EXCLUIR";
            this.btnExcluirTarefa.UseVisualStyleBackColor = true;
            this.btnExcluirTarefa.Click += new System.EventHandler(this.btnExcluirTarefa_Click);
            // 
            // btnEditarTarefa
            // 
            this.btnEditarTarefa.Location = new System.Drawing.Point(12, 194);
            this.btnEditarTarefa.Name = "btnEditarTarefa";
            this.btnEditarTarefa.Size = new System.Drawing.Size(130, 68);
            this.btnEditarTarefa.TabIndex = 3;
            this.btnEditarTarefa.Text = "EDITAR";
            this.btnEditarTarefa.UseVisualStyleBackColor = true;
            this.btnEditarTarefa.Click += new System.EventHandler(this.btnEditarTarefa_Click);
            // 
            // btnVoltarTarefa
            // 
            this.btnVoltarTarefa.Location = new System.Drawing.Point(785, 518);
            this.btnVoltarTarefa.Name = "btnVoltarTarefa";
            this.btnVoltarTarefa.Size = new System.Drawing.Size(107, 53);
            this.btnVoltarTarefa.TabIndex = 5;
            this.btnVoltarTarefa.Text = "VOLTAR";
            this.btnVoltarTarefa.UseVisualStyleBackColor = true;
            this.btnVoltarTarefa.Click += new System.EventHandler(this.btnVoltarTarefa_Click);
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(12, 268);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(130, 68);
            this.btnAdicionarItem.TabIndex = 6;
            this.btnAdicionarItem.Text = "ADICIONAR ITENS ";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // btnConcluirItem
            // 
            this.btnConcluirItem.Location = new System.Drawing.Point(12, 342);
            this.btnConcluirItem.Name = "btnConcluirItem";
            this.btnConcluirItem.Size = new System.Drawing.Size(130, 68);
            this.btnConcluirItem.TabIndex = 7;
            this.btnConcluirItem.Text = "CONCLUIR ITENS";
            this.btnConcluirItem.UseVisualStyleBackColor = true;
            this.btnConcluirItem.Click += new System.EventHandler(this.btnConcluirItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "TAREFA";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(161, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 496);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listTarefasPendentes);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(699, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tarefas Pendentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listTarefasPendentes
            // 
            this.listTarefasPendentes.FormattingEnabled = true;
            this.listTarefasPendentes.ItemHeight = 25;
            this.listTarefasPendentes.Location = new System.Drawing.Point(9, 25);
            this.listTarefasPendentes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listTarefasPendentes.Name = "listTarefasPendentes";
            this.listTarefasPendentes.Size = new System.Drawing.Size(690, 329);
            this.listTarefasPendentes.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listTarefasConcluidas);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(699, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tarefas Concluídas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listTarefasConcluidas
            // 
            this.listTarefasConcluidas.FormattingEnabled = true;
            this.listTarefasConcluidas.ItemHeight = 25;
            this.listTarefasConcluidas.Location = new System.Drawing.Point(14, 25);
            this.listTarefasConcluidas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listTarefasConcluidas.Name = "listTarefasConcluidas";
            this.listTarefasConcluidas.Size = new System.Drawing.Size(685, 304);
            this.listTarefasConcluidas.TabIndex = 7;
            // 
            // TarefaInicialForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 583);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConcluirItem);
            this.Controls.Add(this.btnAdicionarItem);
            this.Controls.Add(this.btnVoltarTarefa);
            this.Controls.Add(this.btnEditarTarefa);
            this.Controls.Add(this.btnExcluirTarefa);
            this.Controls.Add(this.btnCriarTarefa);
            this.Name = "TarefaInicialForms";
            this.Text = "TelaTarefaInicial";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarTarefa;
        private System.Windows.Forms.Button btnExcluirTarefa;
        private System.Windows.Forms.Button btnEditarTarefa;
        private System.Windows.Forms.Button btnVoltarTarefa;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Button btnConcluirItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listTarefasPendentes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listTarefasConcluidas;
    }
}