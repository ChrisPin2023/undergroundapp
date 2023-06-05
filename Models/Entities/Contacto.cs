using underground.api.Models.Entities;

namespace Models.Entities
{
    public class Contacto: Base
    {
        //Propriedades da classe - Tabela
        public string NumTelefonePessoal { get; set; }
        public string NumTelefoneTrabalho { get; set; }
        public string EmailPessoal { get; set; }
        public string EmailTrabalho { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string NumWatsapp { get; set; }

        // Chave estrangeira
        public Guid PessoaId { get; set; }

        //Relacionamentos - Cardinalidades
        public virtual Pessoa Pessoa { get; set; }
    }
}