using ClubeLeitura.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda
{
    public class Itens : EntidadeBase
    {

        public string Descricao { get; set; }
        public bool Status { get; set; }





        public override string Validar()
        {
            return " ";
        }
    }




}
