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
    public partial class CadastroContato : Form
    {
        public Contato? contato;

        public CadastroContato(Contato contato)
        {
            InitializeComponent();

            this.contato = contato;

            if (contato != null)
            {
                textBoxNome.Text = contato.Nome;
                textBoxEmail.Text = contato.Email;
                textBoxTelefone.Text = contato.Telefone;
                textBoxEmpresa.Text = contato.Empresa;
                textBoxCargoEmpresa.Text = contato.Cargo;
            }

        }

        public Contato Contato
        {
            get { return contato!; }
            set { contato = value; }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            contato!.Nome = textBoxNome.Text;
            contato!.Email = textBoxEmail.Text;
            contato!.Telefone = textBoxTelefone.Text;
            contato!.Empresa = textBoxEmpresa.Text;
            contato!.Cargo = textBoxCargoEmpresa.Text;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
