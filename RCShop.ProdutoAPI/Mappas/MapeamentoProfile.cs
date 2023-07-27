using AutoMapper;
using RCShop.ProdutoAPI.DTOs;
using RCShop.ProdutoAPI.Models;

namespace RCShop.ProdutoAPI.Mappas;

public class MapeamentoProfile : Profile
{
    public MapeamentoProfile()
    {
        CreateMap<Categoria,CategoriaDTO>().ReverseMap();
        CreateMap<Produto, ProdutoDTO>().ReverseMap();
    }
}
