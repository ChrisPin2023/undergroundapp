
using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class Medico: Base
    {
        [MaxLength(20, ErrorMessage ="minimo 20 carateres")] 
        public string NumOdem { get; set; }
        [MaxLength(20, ErrorMessage ="minimo 20 carateres")]
        public string Especialidade { get; set; }

        // chaves estrangeiras
        public Guid PessoaId { get; set; }

        // relaciomanetos - cardinalidades
        public virtual Pessoa Pessoa { get; set; }
    }
}