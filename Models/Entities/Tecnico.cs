using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class Tecnico: Base
    {
        [MaxLength(30, ErrorMessage ="Limite de caracteres excedido")]
        public string FuncaoExtra { get; set; }
        [MaxLength(15, ErrorMessage ="Limite de caracteres excedido")]
        public string RefTecnico { get; set; }

        // chave estrangeira
        public Guid PessoaId { get; set; }

        // // relaciomanetos - cardinalidades
        public virtual Pessoa Pessoa { get; set; } 
    }
}