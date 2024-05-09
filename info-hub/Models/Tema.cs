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
        public string Esporte { get; set; }

        [Table("Program")]
        public class Program
        {
            [Key]
            public int Id { get; set; }

            [Required(ErrorMessage = "Obrigatório Informar o tema")]
            public string Politica { get; set; }


            public string Titulo { get; set; }
       
            public string Conteudo { get; set; }
            
            public string Tema { get; set; }
        }
          public class Program
        {
            static void Main(string[] args)
            {
                // Criando algumas notícias de exemplo
                var noticias = new List<Noticia>
            {
                new Noticia { Titulo = "Política: Eleições 2024", Conteudo = "Candidatos debatem propostas para a cidade", Tema = "Política" },
                new Noticia { Titulo = "Esportes: Final do Campeonato", Conteudo = "Time A vence o time B por 2 a 1", Tema = "Esportes" },
                new Noticia { Titulo = "Tecnologia: Lançamento do Smartphone X", Conteudo = "Novo modelo promete câmera revolucionária", Tema = "Tecnologia" },
                new Noticia { Titulo = "Cultura: Exposição de Arte Moderna", Conteudo = "Obras de artistas renomados em exibição", Tema = "Cultura" }
            };

                // Filtrando notícias por tema (exemplo: "Esportes")
                var temaDesejado = "Esportes";
                var noticiasFiltradas = noticias.Where(n => n.Tema == temaDesejado);

                Console.WriteLine($"Notícias sobre o tema '{temaDesejado}':");
                foreach (var noticia in noticiasFiltradas)
                {
                    Console.WriteLine($"- {noticia.Titulo}: {noticia.Conteudo}");
                }
            }
        }
    }
}
