using RCShop.ProdutoAPI.Models;

namespace RCShop.ProdutoAPI.DTOs
{
    public class CategoriaDTO
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
