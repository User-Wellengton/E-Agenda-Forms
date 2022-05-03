using ClubeLeitura.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda
{
    public class Compromisso : EntidadeBase
    {

        public Contato contato = new();
        public String Assunto { get; set; }
        public string Local { get; set; }
        public DateTime? DataCompromisso { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraTermino { get; set; }
        public Contato Contato { get { return contato; } set { contato = value; } }

        public Compromisso()
        {
        }

        public override string ToString()
        {
            if (Contato != null)
            {
                return $"ID: {Numero} Assunto: {Assunto} Local: {Local} Data: {DataCompromisso} Hora início: {HoraInicio} Hora fim: {HoraTermino} Contato: {Contato}";
            }
            return $"ID: {Numero} Assunto: {Assunto} Local: {Local} Data: {DataCompromisso} Hora início: {HoraInicio} Hora fim: {HoraTermino}";
        }


        public override string Validar()
        {
            throw new NotImplementedException();
        }


    }
}
