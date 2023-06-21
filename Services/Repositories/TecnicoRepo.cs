using Models.DataBase;
using Models.Entities;
using Models.Interfaces;

namespace Services.Repositories
{
    public class TecnicoRepo : ITecnico
    {
        private readonly UndergroundDbContext _context;

        public TecnicoRepo(UndergroundDbContext context)
        {
            _context = context;
        }
        

        public IEnumerable<Tecnico> Exibir()
        {
            var tecnicos = _context.Tb_Tecnico;
            return tecnicos.ToList();
        }

        public async Task<Tecnico> Exibir(Guid id)
        {
            var tecnico = _context.Tb_Tecnico.FirstOrDefault(t => t.Id == id);
            await Task.CompletedTask;
            return tecnico;
        }

        public async Task Inserir(Tecnico t)
        {
            await _context.AddRangeAsync(t);
            await Salvar();
        }
        public async Task Atualizar(Tecnico t)
        {
            _context.UpdateRange(t);
            await Salvar();
        }

        public async Task Eliminar(Tecnico t)
        {
            _context.RemoveRange(t);
            await Salvar();
        }

        public async Task Salvar()
        {
            await Task.CompletedTask;
            await _context.SaveChangesAsync();
        }
    }
}