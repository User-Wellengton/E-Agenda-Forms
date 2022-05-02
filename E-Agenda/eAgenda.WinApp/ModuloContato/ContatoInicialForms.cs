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
    public partial class ContatoInicialForms : Form
    {

        RepositorioBase<Contato> repositorioContato;

        public ContatoInicialForms(RepositorioBase<Contato> repositorio)
        {
            InitializeComponent();

            repositorioContato = repositorio;
            CarregarContatosNaTela();
        }


        
        private void btnCriarContato_Click(object sender, EventArgs e)
        {
            CadastroContato cadastroContato = new(new Contato());

            DialogResult res = cadastroContato.ShowDialog();

            if (res == DialogResult.OK)
            {
                string status = repositorioContato.Inserir(cadastroContato.contato);

                if (status == "REGISTRO_VALIDO")
                    MessageBox.Show("Contato inserido com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"{status}\nTente novamente", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Error);

                CarregarContatosNaTela();
            }


        }

        private void btnExcluirContato_Click(object sender, EventArgs e)
        {
            Contato contato = (Contato)listContato.SelectedItem; // para selecionar algum para excluir

            Contato contatoSelecionado = (Contato)listContato.SelectedItem;

            bool temAlgo = VerificarContinuidade(contatoSelecionado, "Excluir");
            if (!temAlgo)
                return;

            DialogResult resultado = MessageBox.Show("Excluir esta contato?",
                "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Excluir(contatoSelecionado);
                CarregarContatosNaTela();
            }


        }

        private void btnEditarContato_Click(object sender, EventArgs e)
        {
            Contato contato = (Contato)listContato.SelectedItem; // para selecionar algum para editar 


            Contato contatoSelecionado = (Contato)listContato.SelectedItem;

            Contato novoContato = new();

            novoContato.Numero = contatoSelecionado.Numero;
            novoContato.Nome = contatoSelecionado.Nome;
            novoContato.Email = contatoSelecionado.Email;
            novoContato.Telefone = contatoSelecionado.Telefone;
            novoContato.Empresa = contatoSelecionado.Empresa;
            novoContato.Cargo = contatoSelecionado.Cargo;

            bool temAlgo = VerificarContinuidade(contatoSelecionado, "Editar");
            if (!temAlgo)
                return;

            CadastroContato telaCadContato = new(novoContato); 

            DialogResult res = telaCadContato.ShowDialog();

            if (res == DialogResult.OK)
            {
                string status = repositorioContato.Editar(novoContato, contatoSelecionado);
                if (status == "REGISTRO_VALIDO")
                {
                    MessageBox.Show("Contato editado com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CarregarContatosNaTela();
                }
                else
                {
                    MessageBox.Show($"{status}\nTente novamente", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CarregarContatosNaTela();
                }
            }


        }

        private void btnVizualizarNormal_Click(object sender, EventArgs e)
        {

            CarregarContatosNaTela();

        }

        private void btnVizualizarCargo_Click(object sender, EventArgs e)
        {

            CarregarContatosPorGrupo();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        public bool VerificarContinuidade(Contato contatoSelecionado, string tipo)
        {
            bool temAlgo = repositorioContato.ExisteRegistro();
            if (!temAlgo)
            {
                MessageBox.Show($"Nenhum contato para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (contatoSelecionado == null)
            {
                MessageBox.Show($"Selecione um contato para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void CarregarContatosNaTela()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();
            listContato.Items.Clear();
            foreach (Contato c in contatos)
            {
                listContato.Items.Add(c);
            }
        }

        private void CarregarContatosPorGrupo()
        {
            var contatosPorCargo = repositorioContato.SelecionarTodos()
                                                    .OrderBy(x => x.Cargo)
                                                    .ToList();

            listContato.Items.Clear();

            foreach (var c in contatosPorCargo)
            {
                listContato.Items.Add(c);
            }
        }

        
    }
}
