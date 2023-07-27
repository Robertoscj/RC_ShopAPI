using RCShop.ProdutoAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace RCShop.ProdutoAPI.DTOs
{
    public class ProdutoDTO
    {
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        public int Id { get; set; }
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Preço é obrigatório")]
        public decimal Preco { get; }

        [Required(ErrorMessage = "A Descrição é obrigatória")]
        [MinLength(5)]
        [MaxLength(200)]
        public string Descricao { get; }

        [Required(ErrorMessage = "O Estoque é obrigatório")]
        [Range(1,9999)]
        public long Estoque { get; set; }

        public string ImageURL { get; set; }

        public Categoria Categoria { get; set; }

        public int CategoriaId { get; set; }
    }
}
