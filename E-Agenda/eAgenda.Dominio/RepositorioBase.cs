using System;
using System.Collections.Generic;

namespace E_Agenda
{
    public class RepositorioBase<T> where T : EntidadeBase
    {

        private readonly ISerializator<T> _serializator;

        protected readonly List<T> registros;
        protected int contadorID;
      
        
        public RepositorioBase(JsonSerialization<T> serializator)
        {
            _serializator = serializator;
            registros = serializator.Load();
        }

       
        public string Inserir(T registro)
        {


            string resultado = registro.Validar();
            if (resultado != "REGISTRO_VALIDO")
                return resultado;

            registro.Numero = ++contadorID;
            registros.Add(registro);
            _serializator.Save(registros);
            return "REGISTRO_VALIDO";
        }

        public string Editar(T novoRegistro, T antigoRegistro)
        {
            string resultado = novoRegistro.Validar();
            if (resultado != "REGISTRO_VALIDO")
                return resultado;

            int indice = registros.FindIndex(x => x.Numero == antigoRegistro.Numero);
            registros[indice] = novoRegistro;
            _serializator.Save(registros);
            return "REGISTRO_VALIDO";
        }
        public bool Excluir(T registro)
        {          
             bool excluiu =  registros.Remove(registro);
            _serializator.Save(registros);
            return excluiu;
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
        public List<T> FiltrarDuplamente(Predicate<T> condicao, Predicate<T> condicao2)
        {
            List<T> registrosFiltrados = new List<T>();

            foreach (T registro in registros)
                if (condicao(registro) && condicao2(registro))
                    registrosFiltrados.Add(registro);

            return registrosFiltrados;
        }

        public void AtualizarId()
        {
            int idatualiazado = 0;
            foreach (T registro in registros)
                registro.Numero = ++idatualiazado;

        }


    }
}
