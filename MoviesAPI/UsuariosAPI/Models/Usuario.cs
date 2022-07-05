using System.ComponentModel.DataAnnotations;

namespace UsuariosAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}
