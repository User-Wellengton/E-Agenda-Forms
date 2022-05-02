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
        public Contato contato;


        public CadastroContato(Contato contato)
        {
            InitializeComponent();

            this.contato = contato; 
        }

      
    }
}
