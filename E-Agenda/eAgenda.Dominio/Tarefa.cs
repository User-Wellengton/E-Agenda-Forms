using ClubeLeitura.ConsoleApp.Compartilhado;
using E_Agenda;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E_Agenda
{
   
    public class Tarefa : EntidadeBase
    {
        
        public PrioridadeEnum Prioridade;

        public int Numero { get; set; }
        public string Titulo { get; set; }
        
        public DateTime DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public double percentual { get; set; }
       

        public override string ToString()
        {           

            return $"Número: {Numero}, Título: {Titulo}, Prioridade: {Prioridade},Data Criação: {DataCriacao}" +
                $", Data de Conclusão: {DataConclusao}, Percentual: {percentual}";
        }

        public override string Validar()
        {
            throw new NotImplementedException();
        }

    }
}
