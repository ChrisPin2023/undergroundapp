namespace Models.Interfaces
{
    public interface IBase <T> where T:class
    {
        Task Inserir(T t);
        void Eliminar(Guid id);
        Task Atualizar(T t);
        IEnumerable<T> Exibir();
        Task Exibir(Guid id);
    }
}