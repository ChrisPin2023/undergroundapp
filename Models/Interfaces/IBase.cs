namespace Models.Interfaces
{
    public interface IBase <T> where T:class
    {
        Task Inserir(T t);
        Task Eliminar(T t);
        Task Atualizar(T t);
        IEnumerable <T> Exibir();
        Task<T> Exibir(Guid id);
        Task Salvar();
    }
}