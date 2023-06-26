using System.ComponentModel.DataAnnotations;

namespace Services.DTOS.Hospital
{
    public class AddHospitalDTO
    {
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [MinLength(5, ErrorMessage ="Minimo 5 Caracteres"), 
        MaxLength(30, ErrorMessage ="Limite de caracteres excedido")]
        public string NomeHospital { get; set; }
        [MaxLength(30, ErrorMessage ="Limite de caracteres excedido")]
        public string Servicos { get; set; }

    }
}