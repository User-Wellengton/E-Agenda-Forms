using ClubeLeitura.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda
{
    public class Contato : EntidadeBase
    {
       
        public string Nome { get; set; }
        public string EMail { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }


        public override string ToString()
        {

            return $"Número: {Numero}, Nome: {Nome}, Email: {EMail},Telefone: {Telefone}" +
                $", Empresa: {Empresa}, Cargo na empressa: {Cargo}";
        }


        public override string Validar()
        {
            throw new NotImplementedException();
        }

    }
}
