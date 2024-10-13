using AutoMapper;
using Ambev.Application.Dtos;
using Ambev.Domain.Entities;

namespace Ambev.Application.Mappings
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile() 
        { 
            CreateMap<Cliente,ClienteDto>().ReverseMap();
            CreateMap<Produto, ProdutoDto>().ReverseMap();
            CreateMap<Filial, FilialDto>().ReverseMap();
            CreateMap<Venda, VendaDto>().ReverseMap();
        }
    }
}
