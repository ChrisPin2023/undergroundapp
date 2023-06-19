using Models.Entities;

namespace Models.Interfaces
{
    public interface IDador: IBase<Dador>
    {
        IEnumerable<Dador> Exibir(string grupoS);
        IEnumerable<Dador> ExibirTipo(string tipo);
    }
}