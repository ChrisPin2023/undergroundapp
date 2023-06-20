using Models.DataBase;
using Models.Entities;
using Models.Interfaces;

namespace Services.Repositories
{
    public class HospitalRepo : IHospital
    {
        // injecao de dependencia do contexto
        private readonly UndergroundDbContext _context;
        public HospitalRepo(UndergroundDbContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Hospital> Exibir()
        {
            var hospitais = _context.Tb_Hospital;
            return hospitais.ToList();
        }

        public async Task<Hospital> Exibir(Guid id)
        {
            var hospital = _context.Tb_Hospital.FirstOrDefault(p => p.Id == id);
            await Task.Delay(1000);
            return hospital;
        }

        public async Task Inserir(Hospital t)
        {
            _context.AddRange(t);
            await Salvar();
        }

        public async Task Atualizar(Hospital t)
        {
            _context.UpdateRange(t);
            await Salvar();
        }

        public async Task Eliminar(Hospital t)
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