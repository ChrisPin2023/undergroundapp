using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class Stock: Base
    {
        [MaxLength(8, ErrorMessage ="Limite de caracteres excedido")]
        public DateTime DataEntrada { get; set; }
        [MaxLength(8, ErrorMessage ="Limite de caracteres excedido")]
        public DateTime DataSaida { get; set; }  
        public int QtdEntrada { get; set; }
        [MaxLength(30, ErrorMessage ="Limite de caracteres excedido")]
        public int QtdSaida { get; set; }
        [MaxLength(30, ErrorMessage ="Limite de caracteres excedido")]
        public int QtdMinima { get; set; }
        [MaxLength(30, ErrorMessage ="Limite de caracteres excedido")]

        // chaves estrangeiras
        //public Guid SaidaId { get; set; }

        // relacionamento - cardinalidades
        public virtual Saida Saida { get; set; }
    }
}