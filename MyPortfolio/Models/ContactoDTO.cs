using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models
{
    public class ContactoDTO
    {
        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "El asunto del mensaje es obligatorio")]
        [Display(Name = "Asunto")]
        public string Asunto { get; set; }

        [Required(ErrorMessage = "Cuerpo del mensaje")]
        [Display(Name = "Cuerpo del mensaje")]
        public string Cuerpo { get; set; }
    }
}
