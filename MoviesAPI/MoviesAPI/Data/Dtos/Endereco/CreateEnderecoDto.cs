using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos.Endereco
{
    public class CreateEnderecoDto
    {
        [Required(ErrorMessage = "O campo de logradouro é obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo de bairro é obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo de numero é obrigatório")]
        public string Numero { get; set; }
    }
}
