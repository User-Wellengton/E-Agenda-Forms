using ClubeLeitura.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda
{
    public class Compromisso : EntidadeBase
    {

        public String Assunto { get; set; }
        public string Local { get; set; }
        public DateTime DataCompromisso { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }

        public override string ToString()
        {

            return $"Número: {Numero}, Assunto: {Assunto}, Local: {Local},Data do Compromisso: {DataCompromisso}" +
                $", Horario de Inicio: {HoraInicio}, Horario de Termino: {HoraTermino}";
        }

        public override string Validar()
        {
            throw new NotImplementedException();
        }



    }
}
