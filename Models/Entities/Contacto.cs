
using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class Contacto: Base
    {
        //Propriedades da classe - Tabela
        [DataType(DataType.PhoneNumber)]
        [MaxLength(13, ErrorMessage ="Não exceda os 13 caracteres")]
        public string NumTelefonePessoal { get; set; }

        [MaxLength(13, ErrorMessage ="Não exceda os 13 caracteres")]
        [DataType(DataType.PhoneNumber)]
        public string NumTelefoneTrabalho { get; set; }

        [MaxLength(200, ErrorMessage ="Não exceda os 200 caracteres")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email mal inserido")]
        public string EmailPessoal { get; set; }

        [MaxLength(200, ErrorMessage ="Não exceda os 200 caracteres")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email mal inserido")]
        public string EmailTrabalho { get; set; }

        [MaxLength(50, ErrorMessage ="Não exceda os 50 caracteres")]
        public string Facebook { get; set; }

        [MaxLength(50, ErrorMessage ="Não exceda os 50 caracteres")]
        public string Instagram { get; set; }

        [MaxLength(13, ErrorMessage ="Não exceda os 13 caracteres")]
        [DataType(DataType.PhoneNumber)]
        public string NumWatsapp { get; set; }

        // Chave estrangeira
        public Guid PessoaId { get; set; }

        //Relacionamentos - Cardinalidades
        public virtual Pessoa Pessoa { get; set; }
    }
}