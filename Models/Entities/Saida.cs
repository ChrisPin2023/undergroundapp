using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class Saida:Base
    {

        [MaxLength(15, ErrorMessage ="Limite de caracteres excedido")]
        public int QtdBolsas { get; set; }
        // chaves estrangeiras
        public Guid PedidoId { get; set; }
        public int Quantidade { get; set; }
        public Guid StockId {get; set; }
        public Guid MedicoId { get; set; }

        //cardinalidades
        public virtual Pedido Pedido { get; set; } 
        public virtual Stock Stock { get; set; } 
        public Medico Medico { get; set; }


    }
}