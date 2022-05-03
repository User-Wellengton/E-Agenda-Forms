using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda
{
    public partial class CadastroCompromisso : Form
    {

        private Compromisso? compromisso;
        private RepositorioBase<Contato> repositorioContato;

        public CadastroCompromisso(Compromisso compromissoVazio, RepositorioBase<Contato> repositorioContato)
        {
            InitializeComponent();

            this.repositorioContato = repositorioContato;
            compromisso = compromissoVazio;

            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listContatoEmCompromisso.Items.Clear();

            foreach (Contato c in contatos)
            {
                listContatoEmCompromisso.Items.Add(c);
            }

            if (compromisso != null)
            {
                textAssunto.Text = compromisso.Assunto;
                textLocal.Text = compromisso.Local;
                maskedTextData.Text = compromisso.DataCompromisso.ToString();
                maskedTextHoraInicio.Text = compromisso.HoraInicio.ToString();
                maskedTextHoraTermino.Text = compromisso.HoraTermino.ToString();
                if (compromisso.Contato != null)
                    labelContato.Text = "Nenhum";
                else
                    labelContato.Text = compromisso.Contato!.ToString();
            }
        }

        public Compromisso Compromisso
        {
            get { return compromisso!; }
            set { compromisso = value; }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            compromisso!.Assunto = textAssunto.Text;
            compromisso!.Local = textLocal.Text;
            if (maskedTextData.Text != "  /  /")
                compromisso.DataCompromisso = DateTime.Parse(maskedTextData.Text);// fazendo a conversao para timeeSpan, o TEXTBOX deve ser compativel 
            else
                compromisso.DataCompromisso = null;
            compromisso.HoraInicio = TimeSpan.Parse(maskedTextHoraInicio.Text); // fazendo a conversao para timeeSpan, o TEXTBOX deve ser compativel 
            compromisso.HoraTermino = TimeSpan.Parse(maskedTextHoraTermino.Text);// fazendo a conversao para timeeSpan, o TEXTBOX deve ser compativel 
            if (listContatoEmCompromisso.SelectedItem == null) // puxando contato
            {
                listContatoEmCompromisso.SelectedItem = compromisso.Contato;
            }
            compromisso.Contato = (Contato)listContatoEmCompromisso.SelectedItem;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
