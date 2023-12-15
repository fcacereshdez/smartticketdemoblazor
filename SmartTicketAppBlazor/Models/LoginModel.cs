using System.ComponentModel.DataAnnotations;

namespace SmartTicketAppBlazor.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Se requiere el correo electrónico")]
        [EmailAddress(ErrorMessage = "Debe ser un correo válido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Se requiere la contraseña")]
        public string? Password { get; set; }
    }
}
