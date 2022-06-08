using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos.Endereco
{
    public class UpdateEnderecoDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
    }
}
