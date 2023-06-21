using Models.DataBase;
using Models.Entities;
using Models.Interfaces;

namespace Services.Repositories
{
    public class SaidaRepo : ISaida
    {
        private readonly UndergroundDbContext _context;

        public SaidaRepo(UndergroundDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Saida> Exibir()
        {
            var saidas = _context.Tb_Saida;
            return saidas.ToList();
        }

        public async Task<Saida> Exibir(Guid id)
        {
            var saida = _context.Tb_Saida.FirstOrDefault(c => c.Id==id);
            await Task.CompletedTask;
            return saida;
        }
        public async Task Atualizar(Saida t)
        {
            _context.UpdateRange(t);
            await Salvar();
    
        }

        public async Task Eliminar(Saida t)
        {
             _context.RemoveRange(t);
            await Salvar();
        }

        public async Task Inserir(Saida t)
        {
            await _context.AddRangeAsync(t);
            await Salvar();
        }

        public async Task Salvar()
        {
            await _context.SaveChangesAsync();
            await Salvar();
        }
    }
}