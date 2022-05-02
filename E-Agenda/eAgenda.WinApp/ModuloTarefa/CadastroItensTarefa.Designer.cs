namespace GestaoTarefas.WinApp
{
    partial class CadastroItensTarefa
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtTituloItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listItensTarefa = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTituloTarefa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(393, 405);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 65);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(277, 405);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(103, 65);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtTituloItem
            // 
            this.txtTituloItem.Location = new System.Drawing.Point(83, 95);
            this.txtTituloItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTituloItem.Name = "txtTituloItem";
            this.txtTituloItem.Size = new System.Drawing.Size(277, 31);
            this.txtTituloItem.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Título:";
            // 
            // listItensTarefa
            // 
            this.listItensTarefa.FormattingEnabled = true;
            this.listItensTarefa.ItemHeight = 25;
            this.listItensTarefa.Location = new System.Drawing.Point(17, 168);
            this.listItensTarefa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listItensTarefa.Name = "listItensTarefa";
            this.listItensTarefa.Size = new System.Drawing.Size(477, 204);
            this.listItensTarefa.TabIndex = 10;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(373, 95);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(107, 38);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tarefa:";
            // 
            // labelTituloTarefa
            // 
            this.labelTituloTarefa.AutoSize = true;
            this.labelTituloTarefa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTituloTarefa.Location = new System.Drawing.Point(84, 32);
            this.labelTituloTarefa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloTarefa.Name = "labelTituloTarefa";
            this.labelTituloTarefa.Size = new System.Drawing.Size(134, 25);
            this.labelTituloTarefa.TabIndex = 13;
            this.labelTituloTarefa.Text = "[Titulo Tarefa]";
            // 
            // CadastroItensTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 495);
            this.Controls.Add(this.labelTituloTarefa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.listItensTarefa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTituloItem);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroItensTarefa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Itens da Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtTituloItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listItensTarefa;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTituloTarefa;
    }
}