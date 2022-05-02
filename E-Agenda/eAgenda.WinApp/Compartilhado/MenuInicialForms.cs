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
    public partial class MenuInicialForms : Form
    {
        RepositorioBase<Contato> repositorioContato;
        ContatoInicialForms? contatoInicialForms;

        RepositorioBase<Compromisso> repositorioCompromisso;
        CompromissoInicialForms? compromissoInicialForms;

        RepositorioBase<Tarefa> repositorioTarefa;
        TarefaInicialForms? tarefaInicialForms;


        public MenuInicialForms()
        {
            InitializeComponent();

            repositorioContato = new RepositorioBase<Contato>();

            repositorioCompromisso = new RepositorioBase<Compromisso>();

            repositorioTarefa = new RepositorioBase<Tarefa>();


        }

        private void btnCompromissoInicial_Click(object sender, EventArgs e)
        {
            compromissoInicialForms = new(repositorioCompromisso);
            compromissoInicialForms.Show();


        }

        private void btnTarefaInicial_Click(object sender, EventArgs e)
        {

        }

        private void btnContatoInicial_Click(object sender, EventArgs e)
        {
            contatoInicialForms = new(repositorioContato);
            contatoInicialForms.Show();
        }
    }
}
