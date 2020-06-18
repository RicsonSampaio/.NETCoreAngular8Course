using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class Produto
    {
        [Key]
        [Display(Name = "Id")]
        public int ProdutoId { get; set; }

        [Required]
        [Display(Name = "Nome do Produto")]
        [StringLength(25, ErrorMessage = "O nome deve ser entre 1 ate 100 caracteres")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Nome do Produto")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Valor deve ser maior ou igual a 1")]
        public string Estoque { get; set; }

        [Required]
        [Display(Name = "Preço")]
        public string Preco { get; set; }
    }
}
