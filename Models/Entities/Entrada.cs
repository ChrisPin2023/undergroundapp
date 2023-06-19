
using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class Entrada:Base
    {
        public int Qtd { get; set; }
        [MaxLength(5, ErrorMessage ="Não exceda os 5 caracteres")]
        public string Gsanguineo { get; set; }

        [MaxLength(15, ErrorMessage ="Não exceda os 15 caracteres")]
        public string  Tipo { get; set; }
        public Guid StockId {get; set;}
        public Guid TecnicoId { get; set; }

        public Stock Stock {get; set;}
        public Tecnico Tecnico { get; set; }
        
    }

}