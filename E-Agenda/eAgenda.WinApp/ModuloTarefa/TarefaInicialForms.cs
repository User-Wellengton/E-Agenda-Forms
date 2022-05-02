using GestaoTarefas.WinApp;
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
    public partial class TarefaInicialForms : Form
    {
        public TarefaInicialForms()
        {
            InitializeComponent();
        }

        private void TarefaInicialForms_Load(object sender, EventArgs e)
        {

        }

        private void btnCriarTarefa_Click(object sender, EventArgs e)
        {
            CadastroItensTarefa tela = new CadastroItensTarefa();
            tela.Tarefa = new Tarefa();

            DialogResult resultado = tela.ShowDialog();
        }
    }
}
