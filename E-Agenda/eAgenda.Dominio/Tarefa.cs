﻿using ClubeLeitura.ConsoleApp.Compartilhado;
using E_Agenda;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_Agenda
{
   
    public class Tarefa : EntidadeBase, IEnumerable
    {
        private List<Itens> itens = new List<Itens>();

        public decimal Percentual { get; set; }
        public int prioridade { get; set; }
        public string Prioridade { get; set; }
        public string Titulo { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public DateTime? DataDeConclusao { get; set; }
        public List<Itens> ListaDeItens { get { return itens; } }


        public Tarefa()
        {
            DataDeCriacao = DateTime.Now;
        }

        public override string ToString()
        {
            Percentual = CalcularPercentualConcluido();

            if (DataDeConclusao.HasValue)
            {
                return $"ID: {Numero}, Título: {Titulo}, Percentual: {Percentual}, " +
                    $"Concluída: {DataDeConclusao.Value.ToShortDateString()}";

            }


            return $" ID: { Numero}, Título: {Titulo}, Percentual: {Percentual} ";
        }

        public void AdicionarItemNaTarefa(Itens items)
        {
            if (ListaDeItens.Exists(x => x.Equals(items)) == false)
                itens.Add(items);
        }

        public void ConcluirItem(Itens item)
        {
            Itens itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.Concluir();

            Percentual = CalcularPercentualConcluido();

            if (Percentual == 100)
                DataDeConclusao = DateTime.Now;
        }

        public void MarcarPendente(Itens item)
        {
            Itens itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.MarcarPendente();
        }

        public decimal CalcularPercentualConcluido()
        {
            if (itens.Count == 0)
                return 0;

            int qtdConcluidas = itens.Count(x => x.itemConcluido);

            var percentualConcluido = (qtdConcluidas / (decimal)itens.Count()) * 100;

            return Math.Round(percentualConcluido, 1);
        }

        public override string Validar()
        {
            StringBuilder sb = new StringBuilder();

            if (Titulo == "")
                sb.AppendLine("Nome já Existe");

            if (string.IsNullOrEmpty(Titulo))
                sb.AppendLine("É necessário ter um titulo!");

            if (Prioridade == null)
                sb.AppendLine("A prioridade tem que ser selecionada!");

            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void AtualizarItens(List<Itens> itensConcluidos, List<Itens> itensPendentes)
        {
            foreach (var item in itensConcluidos)
            {
                ConcluirItem(item);
            }

            foreach (var item in itensPendentes)
            {
                MarcarPendente(item);
            }

        }




    }
}
