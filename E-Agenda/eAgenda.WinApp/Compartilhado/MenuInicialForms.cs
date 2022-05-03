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
        private readonly JsonSerialization<Tarefa> _jsonTarefaSerialization;
        private readonly JsonSerialization<Contato> _jsonContatoSerialization;
        private readonly JsonSerialization<Compromisso> _jsonCompromissoSerialization;

        RepositorioBase<Contato> repositorioContato;
        ContatoInicialForms? contatoInicialForms;

        RepositorioBase<Compromisso> repositorioCompromisso;
        CompromissoInicialForms? compromissoInicialForms;

        RepositorioBase<Tarefa> repositorioTarefa;
        TarefaInicialForms? tarefaInicialForms;

        public MenuInicialForms()
        {
            _jsonTarefaSerialization = new(@"C:\Temp\Tarefas");
            _jsonContatoSerialization = new(@"C:\Temp\Contato");
            _jsonCompromissoSerialization = new(@"C:\Temp\Compromisso");

            repositorioContato = new RepositorioBase<Contato>(_jsonContatoSerialization);

            repositorioCompromisso = new RepositorioBase<Compromisso>(_jsonCompromissoSerialization);

            repositorioTarefa = new RepositorioBase<Tarefa>(_jsonTarefaSerialization);


            InitializeComponent();          

        }

        private void btnCompromissoInicial_Click(object sender, EventArgs e)
        {
           compromissoInicialForms = new(repositorioCompromisso, repositorioContato);
           compromissoInicialForms.Show();


        }

        private void btnTarefaInicial_Click(object sender, EventArgs e)
        {

            tarefaInicialForms = new(repositorioTarefa, _jsonTarefaSerialization);
            tarefaInicialForms.ShowDialog();         

        }

        private void btnContatoInicial_Click(object sender, EventArgs e)
        {
            contatoInicialForms = new(repositorioContato);
            contatoInicialForms.Show();
        }
    }
}
