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
            this.listTarefa = new System.Windows.Forms.ListBox();
            this.btnExcluirTarefa = new System.Windows.Forms.Button();
            this.btnEditarTarefa = new System.Windows.Forms.Button();
            this.btnVoltarTarefa = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.btnConcluirItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
           
            // 
            // listTarefa
            // 
            this.listTarefa.FormattingEnabled = true;
            this.listTarefa.ItemHeight = 25;
            this.listTarefa.Location = new System.Drawing.Point(175, 48);
            this.listTarefa.Name = "listTarefa";
            this.listTarefa.Size = new System.Drawing.Size(693, 454);
            this.listTarefa.TabIndex = 1;
            // 
            // btnExcluirTarefa
            // 
            this.btnExcluirTarefa.Location = new System.Drawing.Point(12, 120);
            this.btnExcluirTarefa.Name = "btnExcluirTarefa";
            this.btnExcluirTarefa.Size = new System.Drawing.Size(130, 68);
            this.btnExcluirTarefa.TabIndex = 2;
            this.btnExcluirTarefa.Text = "EXCLUIR";
            this.btnExcluirTarefa.UseVisualStyleBackColor = true;
            // 
            // btnEditarTarefa
            // 
            this.btnEditarTarefa.Location = new System.Drawing.Point(12, 194);
            this.btnEditarTarefa.Name = "btnEditarTarefa";
            this.btnEditarTarefa.Size = new System.Drawing.Size(130, 68);
            this.btnEditarTarefa.TabIndex = 3;
            this.btnEditarTarefa.Text = "EDITAR";
            this.btnEditarTarefa.UseVisualStyleBackColor = true;
            // 
            // btnVoltarTarefa
            // 
            this.btnVoltarTarefa.Location = new System.Drawing.Point(785, 518);
            this.btnVoltarTarefa.Name = "btnVoltarTarefa";
            this.btnVoltarTarefa.Size = new System.Drawing.Size(107, 53);
            this.btnVoltarTarefa.TabIndex = 5;
            this.btnVoltarTarefa.Text = "VOLTAR";
            this.btnVoltarTarefa.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(12, 268);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(130, 68);
            this.btnAdicionarItem.TabIndex = 6;
            this.btnAdicionarItem.Text = "ADICIONAR ITENS ";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // btnConcluirItem
            // 
            this.btnConcluirItem.Location = new System.Drawing.Point(12, 342);
            this.btnConcluirItem.Name = "btnConcluirItem";
            this.btnConcluirItem.Size = new System.Drawing.Size(130, 68);
            this.btnConcluirItem.TabIndex = 7;
            this.btnConcluirItem.Text = "CONCLUIR ITENS";
            this.btnConcluirItem.UseVisualStyleBackColor = true;
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
            // TarefaInicialForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConcluirItem);
            this.Controls.Add(this.btnAdicionarItem);
            this.Controls.Add(this.btnVoltarTarefa);
            this.Controls.Add(this.btnEditarTarefa);
            this.Controls.Add(this.btnExcluirTarefa);
            this.Controls.Add(this.listTarefa);
            this.Controls.Add(this.btnCriarTarefa);
            this.Name = "TarefaInicialForms";
            this.Text = "TelaTarefaInicial";
            this.Load += new System.EventHandler(this.TarefaInicialForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarTarefa;
        private System.Windows.Forms.ListBox listTarefa;
        private System.Windows.Forms.Button btnExcluirTarefa;
        private System.Windows.Forms.Button btnEditarTarefa;
        private System.Windows.Forms.Button btnVoltarTarefa;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Button btnConcluirItem;
        private System.Windows.Forms.Label label1;
    }
}