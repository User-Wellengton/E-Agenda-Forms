using ClubeLeitura.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda
{
    public class Contato : EntidadeBase, IEnumerable
    {
        private string nome;
        private string email;
        private string telefone;

        public string Nome { get { return nome; } set { nome = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Telefone { get { return telefone; } set { telefone = value; } }
        public string Empresa { get; set; }
        public string Cargo { get; set; }


        public override string ToString()
        {

            return $"Número: {Numero}, Nome: {Nome}, Email: {Email},Telefone: {Telefone}" +
                $", Empresa: {Empresa}, Cargo na empressa: {Cargo}";
        }


        public override string Validar()
        {
            throw new NotImplementedException();
        }



        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

    }
}
