namespace E_Agenda
{
    partial class ContatoInicialForms
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditarContato = new System.Windows.Forms.Button();
            this.btnExcluirContato = new System.Windows.Forms.Button();
            this.listContato = new System.Windows.Forms.ListBox();
            this.btnCriarContato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVizualizarNormal = new System.Windows.Forms.Button();
            this.btnVizualizarCargo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(796, 523);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 53);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "VOLTAR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEditarContato
            // 
            this.btnEditarContato.Location = new System.Drawing.Point(13, 211);
            this.btnEditarContato.Name = "btnEditarContato";
            this.btnEditarContato.Size = new System.Drawing.Size(130, 68);
            this.btnEditarContato.TabIndex = 11;
            this.btnEditarContato.Text = "EDITAR";
            this.btnEditarContato.UseVisualStyleBackColor = true;
            this.btnEditarContato.Click += new System.EventHandler(this.btnEditarContato_Click);
            // 
            // btnExcluirContato
            // 
            this.btnExcluirContato.Location = new System.Drawing.Point(13, 137);
            this.btnExcluirContato.Name = "btnExcluirContato";
            this.btnExcluirContato.Size = new System.Drawing.Size(130, 68);
            this.btnExcluirContato.TabIndex = 10;
            this.btnExcluirContato.Text = "EXCLUIR";
            this.btnExcluirContato.UseVisualStyleBackColor = true;
            this.btnExcluirContato.Click += new System.EventHandler(this.btnExcluirContato_Click);
            // 
            // listContato
            // 
            this.listContato.FormattingEnabled = true;
            this.listContato.ItemHeight = 25;
            this.listContato.Location = new System.Drawing.Point(180, 63);
            this.listContato.Name = "listContato";
            this.listContato.Size = new System.Drawing.Size(693, 454);
            this.listContato.TabIndex = 9;
           
            // 
            // btnCriarContato
            // 
            this.btnCriarContato.Location = new System.Drawing.Point(13, 63);
            this.btnCriarContato.Name = "btnCriarContato";
            this.btnCriarContato.Size = new System.Drawing.Size(130, 68);
            this.btnCriarContato.TabIndex = 8;
            this.btnCriarContato.Text = "CRIAR";
            this.btnCriarContato.UseVisualStyleBackColor = true;
            this.btnCriarContato.Click += new System.EventHandler(this.btnCriarContato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "CONTATO";
            // 
            // btnVizualizarNormal
            // 
            this.btnVizualizarNormal.Location = new System.Drawing.Point(12, 285);
            this.btnVizualizarNormal.Name = "btnVizualizarNormal";
            this.btnVizualizarNormal.Size = new System.Drawing.Size(130, 68);
            this.btnVizualizarNormal.TabIndex = 15;
            this.btnVizualizarNormal.Text = "VIZUALIZAR NORMAL";
            this.btnVizualizarNormal.UseVisualStyleBackColor = true;
            this.btnVizualizarNormal.Click += new System.EventHandler(this.btnVizualizarNormal_Click);
            // 
            // btnVizualizarCargo
            // 
            this.btnVizualizarCargo.Location = new System.Drawing.Point(12, 359);
            this.btnVizualizarCargo.Name = "btnVizualizarCargo";
            this.btnVizualizarCargo.Size = new System.Drawing.Size(130, 68);
            this.btnVizualizarCargo.TabIndex = 16;
            this.btnVizualizarCargo.Text = "VIZUALIZAR POR CARGO";
            this.btnVizualizarCargo.UseVisualStyleBackColor = true;
            this.btnVizualizarCargo.Click += new System.EventHandler(this.btnVizualizarCargo_Click);
            // 
            // ContatoInicialForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 583);
            this.Controls.Add(this.btnVizualizarCargo);
            this.Controls.Add(this.btnVizualizarNormal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEditarContato);
            this.Controls.Add(this.btnExcluirContato);
            this.Controls.Add(this.listContato);
            this.Controls.Add(this.btnCriarContato);
            this.Name = "ContatoInicialForms";
            this.Text = "ContatoInicialForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEditarContato;
        private System.Windows.Forms.Button btnExcluirContato;
        private System.Windows.Forms.ListBox listContato;
        private System.Windows.Forms.Button btnCriarContato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVizualizarNormal;
        private System.Windows.Forms.Button btnVizualizarCargo;
    }
}