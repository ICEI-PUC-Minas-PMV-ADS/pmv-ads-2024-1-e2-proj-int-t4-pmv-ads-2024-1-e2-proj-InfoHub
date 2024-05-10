using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace info_hub.Models

{
    [Table("Temas")]
    public class Tema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Categoria da notícia")]
        public CategoriaNoticia Categoria { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a notícia")]
        public int NoticiaId { get; set; }

        [ForeignKey("NoticiaId")]
        public Noticia Noticia { get; set; }
    }


    public enum CategoriaNoticia
    {
        [Display(Name = "Últimas Notícias")]
        UltimasNoticias,

        [Display(Name = "Política")]
        Politica
    }

}
