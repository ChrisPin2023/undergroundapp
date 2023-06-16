
using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class Paciente: Base 
    {
        [MaxLength(20, ErrorMessage ="minimo 20 carateres")] 
        public string Patologia { get; set; }
        [MaxLength(10, ErrorMessage ="minimo 20 carateres")] 
        public string Estado { get; set; }

        // chaves estrangeiras
        public Guid PessoaId { get; set; }
        public Guid HospitalId { get; set; }

        // relacionamentos - cardinalidades
        public virtual Pessoa? Pessoa { get; set; } 
        public virtual Hospital Hospital { get; set; }
    }
}