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
    public partial class CompromissoInicialForms : Form
    {

        RepositorioBase<Compromisso> repositorioCompromisso;
        RepositorioBase<Contato>? repositorioContato;
        public CompromissoInicialForms(RepositorioBase<Compromisso> repositorio, RepositorioBase<Contato> repositorioContato)
        {
            InitializeComponent();

            repositorioCompromisso = repositorio;
            this.repositorioContato = repositorioContato;
            CarregarCompromissoNaTela();
        }

        private void btnCriarCompromisso_Click(object sender, EventArgs e)
        {
            CadastroCompromisso telaCadCompromisso = new(new Compromisso(), repositorioContato!);
            DialogResult res = telaCadCompromisso.ShowDialog();
            if (res == DialogResult.OK)
            {
                Compromisso temp = telaCadCompromisso.Compromisso;

                bool podeSeguir = ValidarHorarios(temp);
                if (!podeSeguir)
                    return;

                string status = repositorioCompromisso.Inserir(telaCadCompromisso.Compromisso);

                if (status == "REGISTRO_VALIDO")
                {
                    if (telaCadCompromisso.Compromisso.Contato != null)
                        telaCadCompromisso.Compromisso.Contato.EstaEmCompromisso = true;

                    MessageBox.Show("Compromisso inserido com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show($"{status}\nTente novamente", "Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                CarregarCompromissoNaTela();
            }


        }

        private void btnExcluirCompromisso_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromissosFuturos.SelectedItem;

            bool temAlgo = VerificarContinuidade(compromissoSelecionado, "Excluir");
            if (!temAlgo)
                return;

            DialogResult resultado = MessageBox.Show("Excluir compromisso?",
                "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromissoSelecionado);
                CarregarCompromissoNaTela();
            }
        }

        private void btnEditarCompromisso_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromissosFuturos.SelectedItem;

            Compromisso novoCompromisso = new();

            novoCompromisso.Numero = compromissoSelecionado.Numero;
            novoCompromisso.Assunto = compromissoSelecionado.Assunto;
            novoCompromisso.Local = compromissoSelecionado.Local;
            novoCompromisso.DataCompromisso = compromissoSelecionado.DataCompromisso;
            novoCompromisso.HoraInicio = compromissoSelecionado.HoraInicio;
            novoCompromisso.HoraTermino = compromissoSelecionado.HoraTermino;
            novoCompromisso.Contato = compromissoSelecionado.Contato;

            CadastroCompromisso telaCadCompromisso = new(novoCompromisso, repositorioContato!);            

            DialogResult res = telaCadCompromisso.ShowDialog();

            if (res == DialogResult.OK)
            {
                Compromisso temp = telaCadCompromisso.Compromisso;

                bool podeSeguir = ValidarHorarios(temp);
                if (!podeSeguir)
                    return;

                string status = repositorioCompromisso.Editar(telaCadCompromisso.Compromisso, compromissoSelecionado);
                if (status == "REGISTRO_VALIDO")
                    MessageBox.Show("Compromisso editado com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"{status}\nTente novamente", "Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                CarregarCompromissoNaTela();
            }

        }

        private void btnVizualizarNormal_Click(object sender, EventArgs e)
        {
            CarregarCompromissoNaTela();

        }


        private void btnVoltarTarefa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {

            if (maskedTextInicio.Text != "  /  /" && maskedTextTermino.Text != "  /  /")
            {
                DateTime inicio = DateTime.Parse(maskedTextInicio.Text);
                DateTime fim = DateTime.Parse(maskedTextTermino.Text);

                if (fim < inicio && listCompromissosFuturos.Items.Count > 0)
                {
                    MessageBox.Show("O início não pode ser menor que o fim!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<Compromisso> compromissosNoPeriodo = repositorioCompromisso.FiltrarDuplamente(x => x.DataCompromisso >= inicio, x => x.DataCompromisso <= fim);
                if (compromissosNoPeriodo.Count == 0)
                {
                    MessageBox.Show("Sem compromissos neste período!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                listCompromissosFuturos.Items.Clear();
                foreach (Compromisso c in compromissosNoPeriodo)
                {
                    listCompromissosFuturos.Items.Add(c);
                }
            }
            else if (maskedTextInicio.Text == "  /  /" || maskedTextTermino.Text == "  /  /" && listCompromissosFuturos.Items.Count > 0)
                MessageBox.Show("Preencha ambos os campos para filtrar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (listCompromissosFuturos.Items.Count == 0)
            {
                MessageBox.Show("Sem compromissos para filtrar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public bool VerificarContinuidade(Compromisso compromissoSelecionado, string tipo)
        {
            bool temAlgo = repositorioCompromisso.ExisteRegistro();
            if (!temAlgo)
            {
                MessageBox.Show($"Nenhum compromisso para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (compromissoSelecionado == null)
            {
                MessageBox.Show($"Selecione um compromisso para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }


        private void CarregarCompromissoNaTela()
        {
            CarregarCompromissosFuturos();
            CarregarCompromissosPassados();
        }

        public void CarregarCompromissosPassados()
        {
            List<Compromisso> compromissosPassados = repositorioCompromisso.Filtrar(x => x.DataCompromisso <= DateTime.Now);
            listCompromissosPassados.Items.Clear();
            foreach (Compromisso c in compromissosPassados)
            {
                listCompromissosPassados.Items.Add(c);
            }
        }

        public void CarregarCompromissosFuturos()
        {
            List<Compromisso> compromissosFuturos = repositorioCompromisso.Filtrar(x => x.DataCompromisso > DateTime.Now);
            listCompromissosFuturos.Items.Clear();
            foreach (Compromisso c in compromissosFuturos)
            {
                listCompromissosFuturos.Items.Add(c);
            }
        }

        public bool ValidarHorarios(Compromisso novoCompromisso)
        {
            List<Compromisso> todos = repositorioCompromisso.SelecionarTodos();

            foreach (Compromisso compromissoJaRegistrado in todos)
            {
                if (compromissoJaRegistrado.DataCompromisso == novoCompromisso.DataCompromisso)
                {
                    if (novoCompromisso.HoraInicio >= compromissoJaRegistrado.HoraInicio &&
                        novoCompromisso.HoraInicio <= compromissoJaRegistrado.HoraTermino ||
                        novoCompromisso.HoraTermino <= compromissoJaRegistrado.HoraTermino &&
                        novoCompromisso.HoraTermino >= compromissoJaRegistrado.HoraInicio)
                    {
                        MessageBox.Show("O horário deste compromisso conflita com a de outro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
