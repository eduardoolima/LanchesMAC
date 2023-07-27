using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LanchesMac.Models
{
    public class Snack
    {
        public int Id { get; set; }
        [StringLength(80, MinimumLength = 2, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        [Required(ErrorMessage = "Informe o Nome da categoria")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [StringLength(80, MinimumLength = 2, ErrorMessage = "O campo {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        [Required(ErrorMessage = "Informe o Nome da categoria")]
        [Display(Name = "Descrição Rápida")]
        public string SmallDescription { get; set; }

        [StringLength(280, MinimumLength = 2, ErrorMessage = "O campo {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        [Required(ErrorMessage = "Informe o Nome da categoria")]
        [Display(Name = "Descrição Completa")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Informe o preço")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0.50,999.99, ErrorMessage = "O Preço deve estar entre R$0.50 e R$999.999")]
        public decimal Price { get; set; }

        [Display(Name = "Imagem padrão")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImgPath { get; set; }

        [Display(Name = "Imagem miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImgThumbnailPath { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsFavorite { get; set; }

        [Display(Name = "Dispnível?")]
        public bool IsAvaible { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
