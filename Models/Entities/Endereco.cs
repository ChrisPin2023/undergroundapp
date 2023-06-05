using underground.api.Models.Entities;

namespace Models.Entities
{
    public class Endereco: Base
    {
        //Propriedades da classe - Tabela
        public string NumCasa { get; set; }
        public string Rua { get; set; }
        public string BairroDistrito { get; set; }
        public string Municipio { get; set; }
        public string Provincia { get; set; }

         // relaciomanetos - cardinalidades
        public List <Pessoa> Pessoas { get; set; }
    }
}