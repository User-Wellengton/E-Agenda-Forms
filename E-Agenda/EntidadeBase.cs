namespace ClubeLeitura.ConsoleApp.Compartilhado
{
    public abstract class EntidadeBase
    {
        public int Numero;
        internal int numero;

        public abstract string Validar();
    }
}
