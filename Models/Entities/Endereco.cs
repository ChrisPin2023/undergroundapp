
using System.ComponentModel.DataAnnotations;
namespace Models.Entities
{
    public class Endereco: Base
    {
        //Propriedades da classe - Tabela
        [MaxLength(5, ErrorMessage ="excedeu o limite de carateres")]
        public string NumCasa { get; set; }
        
        [MaxLength(50, ErrorMessage ="excedeu o limite de carateres")]

        public string Rua { get; set; }
        
        [MaxLength(50, ErrorMessage ="excedeu o limite de carateres")]
        public string BairroDistrito { get; set; }
        
        [MaxLength(50, ErrorMessage ="excedeu o limite de carateres")]
        public string Municipio { get; set; }
        
        [MaxLength(50, ErrorMessage ="excedeu o limite de carateres")]
        public string Provincia { get; set; }

         // relaciomanetos - cardinalidades
        public List <Pessoa> Pessoas { get; set; }
    }
}