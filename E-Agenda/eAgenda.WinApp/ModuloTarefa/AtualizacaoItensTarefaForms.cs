using E_Agenda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class AtualizacaoItensTarefaForms : Form
    {
        private readonly Tarefa tarefa;

        public AtualizacaoItensTarefaForms(Tarefa tarefa)
        {
            InitializeComponent();
            this.tarefa = tarefa;

            labelTituloTarefa.Text = tarefa.Titulo;

            CarregarItensTarefa(tarefa);
        }

        private void CarregarItensTarefa(Tarefa tarefa)
        {
            int i = 0;
            foreach (var item in tarefa.ListaDeItens)
            {
                listItensTarefa.Items.Add(item);

                if (item.itemConcluido)
                    listItensTarefa.SetItemChecked(i, true);

                i++;
            }
        }
        public List<Itens> ItensConcluidos
        {
            get
            {
                return listItensTarefa.CheckedItems
                    .Cast<Itens>()
                    .ToList();
            }
        }

        public List<Itens> ItensPendentes
        {
            get
            {
                return listItensTarefa.Items
                    .Cast<Itens>()
                    .Except(ItensConcluidos)
                    .ToList();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }
    }
}
