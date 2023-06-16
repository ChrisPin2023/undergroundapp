using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class Pedido: Base
    {
        [MaxLength(15, ErrorMessage ="Limite de caracteres excedido")]
        public string EstadoPedido { get; set; }
        [MaxLength(10, ErrorMessage ="Limite de caracteres excedido")]
        public string Carater { get; set; }

        //chaves estrangeiras
        public Guid HospitalId { get; set; }


        //relacionamentos - Cardinalidades
        public virtual Hospital Hospital { get; set; }
    }
}