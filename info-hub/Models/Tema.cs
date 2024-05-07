using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace info_hub.Models
{

    [Table("Temas")]
    public class Tema
    {
        [Key]
        public int Id { get; set; }
       
        [Required(ErrorMessage ="Obrigatório Informar o tema")]
        public string Politica { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o tema")]
        public string Mundo { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o tema")]
        public string Economia { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o tema")]
        public string Tecnologia { get; set;}

        [Required(ErrorMessage = "Obrigatório Informar o tema")]
        public string Negócios { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o tema")]
        public string Viagens { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o tema")]
        public string Clima { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o tema")]
        public string Moda { get; set;}

        [Required(ErrorMessage = "Obrigatório Informar o tema")]
        public string Comida { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o tema")]
        public string Esporte { get; set;}

    }
}
