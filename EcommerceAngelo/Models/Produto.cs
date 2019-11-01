using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceAngelo.Models
{      //Annottation ASP.NET Core (Validações)
    [Table("Produtos")]

    public class Produto
    {
        public Produto()
        {
            CriadoEm = DateTime.Now;
        }

        [Key]
        public int ProdutoId { get; set; }

        [Display(Name = "Nome do produto:")]
        [Required(ErrorMessage ="Campo obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(5,ErrorMessage = "No mínimo 5 caracteres!")]
        [MaxLength(50, ErrorMessage = "No máximo 50 caracteres!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public double? Preco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Range(1, 1000, ErrorMessage ="Quantidade apenas entre 1 e 1000!")]
        public int Quantidade { get; set; }

        public DateTime CriadoEm { get; set; }
    }
}
