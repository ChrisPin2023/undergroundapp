using Models.DataBase;
using Models.Entities;
using Models.Interfaces;

namespace Services.Repositories
{
    public class EntradaRepo : IEntrada
    {
        private readonly UndergroundDbContext _context;

        public EntradaRepo(UndergroundDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Entrada> Exibir()
        {
            var entradas = _context.Tb_Entrada;
            return entradas.ToList();
        }

        public async Task<Entrada> Exibir(Guid id)
        {
            var entrada = await _context.Tb_Entrada.FindAsync(id);
            await Task.CompletedTask;
            return entrada;
        }
        public async Task Atualizar(Entrada t)
        {
            _context.UpdateRange(t);
            await Salvar();
        }

        public async Task Inserir(Entrada t)
        {
            await _context.AddRangeAsync(t);
            await Salvar();
        }
        public async Task Eliminar(Entrada t)
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