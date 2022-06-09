using System;
using System.ComponentModel.DataAnnotations;
using MoviesAPI.Models;

namespace MoviesAPI.Data.Dtos
{
    public class ReadCinemaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
        public DateTime HoraDaConsulta { get; set; }
        public Endereco Endereco { get; set; }   
        public Gerente Gerente { get; set; }
    }
}
