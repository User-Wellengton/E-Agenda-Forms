using ClubeLeitura.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            StringBuilder sb = new();

            if (string.IsNullOrEmpty(Nome))
                sb.AppendLine("O nome do contato é obrigatório");
            if (string.IsNullOrEmpty(Email))
                sb.AppendLine("O e-mail do contato é obrigatório");
            if (string.IsNullOrEmpty(Telefone))
                sb.AppendLine("O telefone do contato é obrigatório");

            EmailAddressAttribute e = new();
            if (!e.IsValid(Email))
                sb.AppendLine("O email do contato está fora dos padrões");

            string padrao = @"^\([1-9]{2}\) (?:[2-8]|9 [1-9])[0-9]{3}\-[0-9]{4}$";
            if (!Regex.Match(Telefone, padrao).Success)
                sb.AppendLine("O telefone do contato está fora dos padrões");


            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }



        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

    }
}
