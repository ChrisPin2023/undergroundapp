using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class Dador: Base
    {
        [MaxLength(15, ErrorMessage ="Não exceda os 15 caracteres")]
        public string CodDador { get; set; }
        // chave estrangeira da pessoa
        public Guid PessoaId { get; set; }

        // relaciomanetos - cardinalidades
        public virtual Pessoa Pessoa { get; set; }

    }
}