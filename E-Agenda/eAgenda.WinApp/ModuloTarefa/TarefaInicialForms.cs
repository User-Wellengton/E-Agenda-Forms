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
        private readonly JsonSerialization<Tarefa> tarefaJson;

        RepositorioBase<Tarefa> repositorioTarefa;

        public TarefaInicialForms(RepositorioBase<Tarefa> repositorio, JsonSerialization<Tarefa> Json)
        {
            tarefaJson = Json;  

            repositorioTarefa = repositorio;
            InitializeComponent();
           
            CarregarTarefas();
        }

        private void btnCriarTarefa_Click(object sender, EventArgs e)
        {
            CadastroTarefaForms tela = new(repositorioTarefa);
            tela.Tarefa = new Tarefa();

            DialogResult res = tela.ShowDialog();

            if (res == DialogResult.OK)
            {
                string status = repositorioTarefa.Inserir(tela.tarefa);

                if (status == "REGISTRO_VALIDO")
                {
                    MessageBox.Show("Tarefa inserida com sucesso!", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{status}\nTente novamente", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CarregarTarefas();
            }
        }

        private void btnEditarTarefa_Click(object sender, EventArgs e)
        {

            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            bool temAlgo = VerificarTarefa(tarefaSelecionada, "Editar");
            if (!temAlgo)
                return;

            Tarefa novaTarefa = new();

            foreach (var item in tarefaSelecionada.ListaDeItens)
            {
                novaTarefa.ListaDeItens.Add(item);
            }
            novaTarefa.Numero = tarefaSelecionada.Numero;
            novaTarefa.Titulo = tarefaSelecionada.Titulo;
            novaTarefa.Prioridade = tarefaSelecionada.Prioridade;
            novaTarefa.DataDeCriacao = tarefaSelecionada.DataDeCriacao;
            novaTarefa.DataDeConclusao = tarefaSelecionada.DataDeConclusao;
            novaTarefa.Percentual = tarefaSelecionada.Percentual;

            CadastroTarefaForms tela = new(repositorioTarefa);
            tela.Tarefa = novaTarefa;


            DialogResult res = tela.ShowDialog();

            if (res == DialogResult.OK)
            {
                string status = repositorioTarefa.Editar(tela.Tarefa, tarefaSelecionada);

                if (status == "REGISTRO_VALIDO")
                {
                    MessageBox.Show("Tarefa editada com sucesso!", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CarregarTarefas();
                }
                else
                {
                    MessageBox.Show($"{status}\nTente novamente", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CarregarTarefas();
                }
            }

        }

        private void btnExcluirTarefa_Click(object sender, EventArgs e)
        {

            Tarefa tarefaSelecionadaIncompleta = (Tarefa)listTarefasPendentes.SelectedItem;

            Tarefa tarefaSelecionadaConcluida = (Tarefa)listTarefasConcluidas.SelectedItem;

            if (tarefaSelecionadaIncompleta == null && tarefaSelecionadaConcluida == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Exclusão de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Tarefa paraExcluir = new Tarefa();

            if (tarefaSelecionadaIncompleta == null)
                paraExcluir = tarefaSelecionadaConcluida;
            else
                paraExcluir = tarefaSelecionadaIncompleta;


            DialogResult resultado = MessageBox.Show("Excluir a tarefa?",
                 "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Excluir(paraExcluir);
                repositorioTarefa.AtualizarId();
                CarregarTarefas();
            }

        }

        private void btnVoltarTarefa_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void CarregarTarefas()
        {
            List<Tarefa> tarefasConcluidas =
                repositorioTarefa.Filtrar(
                    x => x.CalcularPercentualConcluido() == 100).
                    OrderByDescending(x => x.prioridade).ThenBy(x => x.Titulo).ToList();

            listTarefasConcluidas.Items.Clear();

            foreach (Tarefa t in tarefasConcluidas)
            {
                listTarefasConcluidas.Items.Add(t);
            }


            List<Tarefa> tarefasPendentes = repositorioTarefa.Filtrar(x => x.CalcularPercentualConcluido() < 100).
                OrderByDescending(x => x.prioridade).ThenBy(x => x.Titulo).ToList();

            listTarefasPendentes.Items.Clear();

            foreach (Tarefa t in tarefasPendentes)
            {
                listTarefasPendentes.Items.Add(t);
            }
        }

        public bool VerificarTarefa(Tarefa TarefaSelecionada, string tipo)
        {
            bool temAlgo = repositorioTarefa.ExisteRegistro();
            if (!temAlgo)
            {
                MessageBox.Show($"Nenhuma Tarefa para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TarefaSelecionada == null)
            {
                MessageBox.Show($"Selecione uma Tarefa para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionadaIncompleta = (Tarefa)listTarefasPendentes.SelectedItem;

            Tarefa tarefaSelecionadaConcluida = (Tarefa)listTarefasConcluidas.SelectedItem;

            if (tarefaSelecionadaIncompleta == null && tarefaSelecionadaConcluida == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Adicionando Items", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Tarefa TarefaSelecionada = new Tarefa();

            if (tarefaSelecionadaIncompleta == null)
                TarefaSelecionada = tarefaSelecionadaConcluida;
            else
                TarefaSelecionada = tarefaSelecionadaIncompleta;

            CadastroItensTarefa tela = new(TarefaSelecionada);


            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<Itens> itens = tela.ItensAdicionados;

                foreach (var item in itens)
                {
                    TarefaSelecionada.AdicionarItemNaTarefa(item);
                }
                tarefaJson.Save(repositorioTarefa.SelecionarTodos());

                CarregarTarefas();
            }


        }

        private void btnConcluirItem_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionadaIncompleta = (Tarefa)listTarefasPendentes.SelectedItem;

            Tarefa tarefaSelecionadaConcluida = (Tarefa)listTarefasConcluidas.SelectedItem;

            if (tarefaSelecionadaIncompleta == null && tarefaSelecionadaConcluida == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Adicionando Items", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Tarefa TarefaSelecionada = new Tarefa();

            if (tarefaSelecionadaIncompleta == null)
                TarefaSelecionada = tarefaSelecionadaConcluida;
            else
                TarefaSelecionada = tarefaSelecionadaIncompleta;

            AtualizacaoItensTarefaForms tela = new(TarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<Itens> itensConcluidos = tela.ItensConcluidos;

                List<Itens> itensPendentes = tela.ItensPendentes;

                TarefaSelecionada.AtualizarItens(itensConcluidos, itensPendentes);
                CarregarTarefas();



            }
        }
    }
}


