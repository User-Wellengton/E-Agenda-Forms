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
    public partial class CadastroTarefaForms : Form
    {
        public Tarefa tarefa;
        public RepositorioBase<Tarefa> repositoriotarefa;

        public CadastroTarefaForms(RepositorioBase<Tarefa> repositorioTarefa)
        {
            InitializeComponent();
            this.repositoriotarefa = repositorioTarefa;
        }

        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                textBoxTitulo.Text = tarefa.Titulo;
                if (tarefa.Prioridade == "Alta")
                {
                    radioButtonAlta.Checked = true;
                }
                else if (tarefa.Prioridade == "Normal")
                {
                    radioButtonNormal.Checked = true;
                }
                else
                {
                    radioButtonBaixa.Checked = true;
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            List<string> Nomes = repositoriotarefa.SelecionarTodos().Select(x => x.Titulo).ToList();

            if (Nomes.Count == 0 || Nomes.Contains(textBoxTitulo.Text) == false)
            {
                tarefa.Titulo = textBoxTitulo.Text;

                if (radioButtonAlta.Checked == true)
                {
                    tarefa.Prioridade = "Alta";
                    tarefa.prioridade = 3;
                }
                else if (radioButtonNormal.Checked == true)
                {
                    tarefa.Prioridade = "Normal";
                    tarefa.prioridade = 2;
                }
                else
                {
                    tarefa.Prioridade = "Baixa";
                    tarefa.prioridade = 1;
                }
            }
            else
            {
                tarefa.Titulo = "";
            }
        }
    }
}
