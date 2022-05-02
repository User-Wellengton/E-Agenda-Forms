namespace E_Agenda
{
    partial class CadastroTarefaForms
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.radioButtonBaixa = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonAlta = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR TAREFA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo:";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(208, 73);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(414, 31);
            this.textBoxTitulo.TabIndex = 2;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(275, 345);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(103, 65);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // radioButtonBaixa
            // 
            this.radioButtonBaixa.AutoSize = true;
            this.radioButtonBaixa.Location = new System.Drawing.Point(208, 165);
            this.radioButtonBaixa.Name = "radioButtonBaixa";
            this.radioButtonBaixa.Size = new System.Drawing.Size(163, 29);
            this.radioButtonBaixa.TabIndex = 13;
            this.radioButtonBaixa.TabStop = true;
            this.radioButtonBaixa.Text = "Prioridade Baixa";
            this.radioButtonBaixa.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(208, 200);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(182, 29);
            this.radioButtonNormal.TabIndex = 14;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Prioridade Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlta
            // 
            this.radioButtonAlta.AutoSize = true;
            this.radioButtonAlta.Location = new System.Drawing.Point(208, 235);
            this.radioButtonAlta.Name = "radioButtonAlta";
            this.radioButtonAlta.Size = new System.Drawing.Size(154, 29);
            this.radioButtonAlta.TabIndex = 15;
            this.radioButtonAlta.TabStop = true;
            this.radioButtonAlta.Text = "Prioridade Alta";
            this.radioButtonAlta.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "SELECIONE UMA PROPRIDADE:";
            // 
            // CadastroTarefaForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonAlta);
            this.Controls.Add(this.radioButtonNormal);
            this.Controls.Add(this.radioButtonBaixa);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroTarefaForms";
            this.Text = "Cadastro Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.RadioButton radioButtonBaixa;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonAlta;
        private System.Windows.Forms.Label label3;
    }
}