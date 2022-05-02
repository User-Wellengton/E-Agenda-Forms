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
    public partial class CadastroItensTarefa : Form
    {
        private readonly Tarefa tarefa;
        public CadastroItensTarefa(Tarefa tarefa)
        {
            InitializeComponent();
            this.tarefa = tarefa;
            labelTituloTarefa.Text = tarefa.Titulo;

            foreach (Itens item in tarefa.ListaDeItens)
            {
                listItensTarefa.Items.Add(item);
            }

        }
        public List<Itens> ItensAdicionados
        {
            get
            {
                return listItensTarefa.Items.Cast<Itens>().ToList();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            List<string> titulos = ItensAdicionados.Select(x => x.Titulo).ToList();

            if (titulos.Count == 0 || titulos.Contains(txtTituloItem.Text) == false)
            {
                Itens itemTarefa = new Itens();

                itemTarefa.Titulo = txtTituloItem.Text;

                listItensTarefa.Items.Add(itemTarefa);
            }
            else
            {
                MessageBox.Show("Não pode Inserir Itens com o mesmo Nome", "Itens",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


