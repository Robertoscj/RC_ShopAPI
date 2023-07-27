namespace RCShop.ProdutoAPI.Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public decimal Preco { get;}

    public string Descricao { get;}

    public long Estoque { get; set; }

    public string ImageURL { get; set;}

    public Categoria Categoria { get; set;}

    public int CategoriaId { get; set;}
}
