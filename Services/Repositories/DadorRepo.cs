using Models.DataBase;
using Models.Entities;
using Models.Interfaces;

namespace Services.Repositories
{
    public class DadorRepo : IDador
    {
        // injecao de dependencia do contexto
        private readonly UndergroundDbContext _context;
        public DadorRepo(UndergroundDbContext context)
        {
            _context = context;
        }

        // exibir todos os dadores
        public IEnumerable<Dador> Exibir()
        {
            var dadores = _context.Tb_Dador;
            return dadores.ToList();
        }

        // exibir pelo grupo sanguineo
        public IEnumerable <Dador> Exibir(string grupoS)
        {
            var dadores = _context.Tb_Dador
                .Where(t => t.Pessoa.GrupoSanguineo ==grupoS);
            return dadores.ToList();
        }

        //Exibir um unico dador
        public async Task<Dador> Exibir(Guid id)
        {
            var dador =_context.Tb_Dador
                .FirstOrDefault(t => t.Id == id);
                await Task.Yield();
            return dador;
        }

        // exibir dador por tipo
        public IEnumerable<Dador> ExibirTipo(string tipo)
        {
            var dadores = _context.Tb_Dador
                .Where(t => t.Pessoa.GrupoSanguineo ==tipo);
            return dadores.ToList();
        }

        // inserir novo dador
        public async Task Inserir(Dador t)
        {
            await _context.AddRangeAsync(t);
            await Salvar();
            
        }

        // atualizar os dados de um dador
        public async Task Atualizar(Dador t)
        {
            _context.UpdateRange(t);
            await Salvar();
        }

        //eliminar um dador do sistema
        public async Task Eliminar(Dador t)
        {
            _context.RemoveRange(t);
            await _context.SaveChangesAsync();
        }

        // metodo para persistir no banco de dados
        public async Task Salvar()
        {
            await _context.SaveChangesAsync();
        }
    }
}