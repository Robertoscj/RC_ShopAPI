using RCShop.ProdutoAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace RCShop.ProdutoAPI.DTOs
{
    public class CategoriaDTO
    {
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
