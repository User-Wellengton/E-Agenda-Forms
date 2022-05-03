namespace E_Agenda
{
    partial class CadastroCompromisso
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
            this.textAssunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listContatoEmCompromisso = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textLocal = new System.Windows.Forms.TextBox();
            this.labelContato = new System.Windows.Forms.Label();
            this.maskedTextData = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextHoraTermino = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(828, 477);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 65);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(712, 477);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(103, 65);
            this.btnGravar.TabIndex = 16;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // textAssunto
            // 
            this.textAssunto.Location = new System.Drawing.Point(215, 67);
            this.textAssunto.Name = "textAssunto";
            this.textAssunto.Size = new System.Drawing.Size(414, 31);
            this.textAssunto.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Assunto :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "CADASTRAR COMPROMISSO";
            // 
            // listContatoEmCompromisso
            // 
            this.listContatoEmCompromisso.FormattingEnabled = true;
            this.listContatoEmCompromisso.ItemHeight = 25;
            this.listContatoEmCompromisso.Location = new System.Drawing.Point(123, 294);
            this.listContatoEmCompromisso.Name = "listContatoEmCompromisso";
            this.listContatoEmCompromisso.Size = new System.Drawing.Size(554, 229);
            this.listContatoEmCompromisso.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Contatos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Local:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Data Compromisso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Horario Inicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Horario Termino:";
            // 
            // textLocal
            // 
            this.textLocal.Location = new System.Drawing.Point(215, 104);
            this.textLocal.Name = "textLocal";
            this.textLocal.Size = new System.Drawing.Size(414, 31);
            this.textLocal.TabIndex = 24;
            // 
            // labelContato
            // 
            this.labelContato.AutoSize = true;
            this.labelContato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContato.Location = new System.Drawing.Point(399, 266);
            this.labelContato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContato.Name = "labelContato";
            this.labelContato.Size = new System.Drawing.Size(85, 25);
            this.labelContato.TabIndex = 28;
            this.labelContato.Text = "Nenhum";
            // 
            // maskedTextData
            // 
            this.maskedTextData.Location = new System.Drawing.Point(215, 141);
            this.maskedTextData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextData.Mask = "00/00/0000";
            this.maskedTextData.Name = "maskedTextData";
            this.maskedTextData.Size = new System.Drawing.Size(350, 31);
            this.maskedTextData.TabIndex = 29;
            this.maskedTextData.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextHoraInicio
            // 
            this.maskedTextHoraInicio.Location = new System.Drawing.Point(215, 177);
            this.maskedTextHoraInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextHoraInicio.Mask = "00:00";
            this.maskedTextHoraInicio.Name = "maskedTextHoraInicio";
            this.maskedTextHoraInicio.Size = new System.Drawing.Size(350, 31);
            this.maskedTextHoraInicio.TabIndex = 30;
            this.maskedTextHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextHoraTermino
            // 
            this.maskedTextHoraTermino.Location = new System.Drawing.Point(215, 215);
            this.maskedTextHoraTermino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextHoraTermino.Mask = "00:00";
            this.maskedTextHoraTermino.Name = "maskedTextHoraTermino";
            this.maskedTextHoraTermino.Size = new System.Drawing.Size(350, 31);
            this.maskedTextHoraTermino.TabIndex = 31;
            this.maskedTextHoraTermino.ValidatingType = typeof(System.DateTime);
            // 
            // CadastroCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 556);
            this.Controls.Add(this.maskedTextHoraTermino);
            this.Controls.Add(this.maskedTextHoraInicio);
            this.Controls.Add(this.maskedTextData);
            this.Controls.Add(this.labelContato);
            this.Controls.Add(this.textLocal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listContatoEmCompromisso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.textAssunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroCompromisso";
            this.Text = "Cadastro Compromisso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox textAssunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listContatoEmCompromisso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textLocal;
        private System.Windows.Forms.Label labelContato;
        private System.Windows.Forms.MaskedTextBox maskedTextData;
        private System.Windows.Forms.MaskedTextBox maskedTextHoraInicio;
        private System.Windows.Forms.MaskedTextBox maskedTextHoraTermino;
    }
}