using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace info_hub.Models
{
    [Table("Noticias")]
    public class Noticia
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Error! Obrigatório informar o tema")]
        public required string Tema { get; set; }

        [Required(ErrorMessage = "Error! Obrigatório informar o título")]
        public required string Titulo { get; set; }

        [Required(ErrorMessage = "Error! Obrigatório informar a data de publicação")]
        public required DateOnly DataPublicacao { get; set; }

        [Required(ErrorMessage = "Error! Obrigatório informar a data de publicação")]
        public required string Url { get; set; }

        public ICollection<Tema> Temas { get; set; }
    }
}
