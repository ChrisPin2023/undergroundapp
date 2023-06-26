using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class Stock: Base
    {
        [MaxLength(8, ErrorMessage ="Limite de caracteres excedido")]
        public string Grupo { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }  
        public int QtdEntrada { get; set; }
        public int QtdSaida { get; set; }
        public int QtdMinima { get; set; }

        // chaves estrangeiras
        //public Guid SaidaId { get; set; }

        // relacionamento - cardinalidades
        public virtual Saida Saida { get; set; }
    }
}