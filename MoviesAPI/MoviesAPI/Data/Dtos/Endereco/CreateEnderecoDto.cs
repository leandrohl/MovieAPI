using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos.Endereco
{
    public class CreateEnderecoDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
    }
}
