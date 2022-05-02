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

        RepositorioBase<Contato> _repositorioContato;
        public CompromissoInicialForms(RepositorioBase<Contato> repositorio)
        {
            InitializeComponent();

            _repositorioContato = repositorio;
           

        }


        
    }
}
