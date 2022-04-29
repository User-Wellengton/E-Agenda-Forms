namespace E_Agenda
{
    partial class MenuInicialForms
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCompromissoInicial = new System.Windows.Forms.Button();
            this.btnTarefaInicial = new System.Windows.Forms.Button();
            this.btnContatoInicial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCompromissoInicial
            // 
            this.btnCompromissoInicial.Location = new System.Drawing.Point(76, 80);
            this.btnCompromissoInicial.Name = "btnCompromissoInicial";
            this.btnCompromissoInicial.Size = new System.Drawing.Size(153, 105);
            this.btnCompromissoInicial.TabIndex = 0;
            this.btnCompromissoInicial.Text = "COMPROMISSO";
            this.btnCompromissoInicial.UseVisualStyleBackColor = true;
            // 
            // btnTarefaInicial
            // 
            this.btnTarefaInicial.Location = new System.Drawing.Point(256, 80);
            this.btnTarefaInicial.Name = "btnTarefaInicial";
            this.btnTarefaInicial.Size = new System.Drawing.Size(166, 105);
            this.btnTarefaInicial.TabIndex = 1;
            this.btnTarefaInicial.Text = "TAREFA";
            this.btnTarefaInicial.UseVisualStyleBackColor = true;
            // 
            // btnContatoInicial
            // 
            this.btnContatoInicial.Location = new System.Drawing.Point(447, 80);
            this.btnContatoInicial.Name = "btnContatoInicial";
            this.btnContatoInicial.Size = new System.Drawing.Size(147, 105);
            this.btnContatoInicial.TabIndex = 2;
            this.btnContatoInicial.Text = "CONTATO";
            this.btnContatoInicial.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestão E- Agenda V2.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuInicialForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContatoInicial);
            this.Controls.Add(this.btnTarefaInicial);
            this.Controls.Add(this.btnCompromissoInicial);
            this.Name = "MenuInicialForms";
            this.Text = "Gestão E - Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompromissoInicial;
        private System.Windows.Forms.Button btnTarefaInicial;
        private System.Windows.Forms.Button btnContatoInicial;
        private System.Windows.Forms.Label label1;
    }
}
