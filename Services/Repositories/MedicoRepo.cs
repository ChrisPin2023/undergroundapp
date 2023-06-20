using Models.DataBase;
using Models.Entities;
using Models.Interfaces;

namespace Services.Repositories
{
    public class MedicoRepo : IMedico
    {
        private readonly UndergroundDbContext _context;

        public MedicoRepo(UndergroundDbContext context)
        {
            _context = context;
        }
        public async Task Atualizar(Medico t)
        {
            _context.UpdateRange(t);
            await Salvar();
        }

        public async Task Eliminar(Medico t)
        {
            _context.RemoveRange(t);
            await Salvar();
        }

        public IEnumerable<Medico> Exibir()
        {
            var medicos=_context.Tb_Medico;
            return medicos.ToList();
        }

        public async Task<Medico> Exibir(Guid id)
        {
            var medico = await _context.Tb_Medico.FindAsync(id);
            return medico;
        }

        public async Task Inserir(Medico t)
        {
            await _context.AddRangeAsync(t);
            await Salvar();
        }

        public async Task Salvar()
        {
            await Task.CompletedTask;
            await _context.SaveChangesAsync();
        }
    }
}