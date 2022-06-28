using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos
{ 
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "O campo titulo é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O genero não pode passar de 30 caracteres")]
        public string Genero { get; set; }

        public int ClassificacaoEtaria { get; set; }
        public int Duracao { get; set; }
    }
}
