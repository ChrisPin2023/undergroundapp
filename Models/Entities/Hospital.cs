
using System.ComponentModel.DataAnnotations;
namespace Models.Entities
{
    public class Hospital: Base
    {
        public Hospital()
        {
            Pacientes = new HashSet<Paciente>();
            Pedidos = new HashSet<Pedido>();
        }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [MinLength(5, ErrorMessage ="Minimo 5 Caracteres"), 
            MaxLength(30, ErrorMessage ="Limite de caracteres excedido")]
        public string NomeHospital { get; set; }
        [MaxLength(30, ErrorMessage ="Limite de caracteres excedido")]
        public string Servicos { get; set; }

        // relacionamento - cardinalidade
        public IEnumerable<Paciente> Pacientes { get; set; }
        public IEnumerable<Pedido> Pedidos { get; set; }
    }
}