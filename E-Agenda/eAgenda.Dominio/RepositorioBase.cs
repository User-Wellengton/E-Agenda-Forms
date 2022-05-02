using System;
using System.Collections.Generic;

namespace E_Agenda
{
    public class RepositorioBase<T> where T : EntidadeBase
    {
        protected readonly List<T> registros;
        protected int contadorID;

        
        public RepositorioBase()
        {
            registros = new List<T>();
        }
        
        public string Inserir(T registro)
        {
            string resultado = registro.Validar();
            if (resultado != "REGISTRO_VALIDO")
                return resultado;

            registro.Numero = ++contadorID;
            registros.Add(registro);
            return "REGISTRO_VALIDO";
        }

        public string Editar(T novoRegistro, T antigoRegistro)
        {
            string resultado = novoRegistro.Validar();
            if (resultado != "REGISTRO_VALIDO")
                return resultado;

            int indice = registros.FindIndex(x => x.Numero == antigoRegistro.Numero);
            registros[indice] = novoRegistro;
            return "REGISTRO_VALIDO";
        }
        public bool Excluir(T registro)
        {
            return registros.Remove(registro);
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }
        public List<T> Filtrar(Predicate<T> condicao)
        {
            return registros.FindAll(condicao);
        }
        public bool ExisteRegistro()
        {
            int quantia = registros.Count;
            if (quantia == 0)
                return false;
            else
                return true;
        }


        public void AtualizarId()
        {
            int idatualiazado = 0;
            foreach (T registro in registros)
                registro.Numero = ++idatualiazado;

        }


    }
}
