using Models.DataBase;
using Models.Entities;
using Models.Interfaces;

namespace Services.Repositories
{
    public class PacienteRepo : IPaciente
    {
        private readonly UndergroundDbContext _context;

        public PacienteRepo(UndergroundDbContext context)
        {
            _context = context;
        }
       
        public IEnumerable<Paciente> Exibir()
        {
            var pacientes = _context.Tb_Paciente;
            return pacientes.ToList();
        }

        public async Task<Paciente> Exibir(Guid id)
        {
            var paciente = _context.Tb_Paciente.FirstOrDefault(t => t.Id == id);
            await Task.CompletedTask;
            return paciente;
        }

        public async Task Atualizar(Paciente t)
        {
            _context.UpdateRange(t);
            await Salvar();
        }

        public async Task Eliminar(Paciente t)
        {
            _context.RemoveRange(t);
            await Salvar();
        }

        public async Task Inserir(Paciente t)
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