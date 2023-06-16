
using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class Naturalidade: Base
    {
        public Naturalidade()
        {
            Pessoas = new HashSet<Pessoa>();
        }
    
        //Propriedades da classe - Tabela
        [MaxLength(10, ErrorMessage ="limite de carateres excedido")]
        public string NumCasa { get; set; }
        [MaxLength(10, ErrorMessage ="limite de carateres excedido")]
        public string Rua { get; set; }
        [MaxLength(10, ErrorMessage ="limite de carateres excedido")]
        public string BairroDistrito { get; set; }
        [MaxLength(10, ErrorMessage ="limite de carateres excedido")]
        public string Municipio { get; set; }
        [MaxLength(10, ErrorMessage ="limite de carateres excedido")] 
        public string Provincia { get; set; }
        [MaxLength(10, ErrorMessage ="limite de carateres excedido")]
        public string Pais { get; set; }

         // relaciomanetos - cardinalidades
        public IEnumerable <Pessoa> Pessoas { get; set; }
        
    }
}