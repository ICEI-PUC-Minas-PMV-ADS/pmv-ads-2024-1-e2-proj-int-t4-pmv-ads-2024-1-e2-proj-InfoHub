using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace info_hub.Models
{
    [Table("Fontes")]
    public class Fonte
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Obrigatório informar o endereço!")]

        public string Endereço { get; set; }
    }
}
