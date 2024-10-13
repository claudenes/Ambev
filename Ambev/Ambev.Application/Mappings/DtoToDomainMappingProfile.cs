using AutoMapper;
using Ambev.Application.Dtos;
using Ambev.Domain.Entities;

namespace Ambev.Application.Mappings
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile() 
        {
            CreateMap<ProdutoDto, Produto>().ReverseMap();
            CreateMap<ClienteDto, Cliente>().ReverseMap();
            CreateMap<FilialDto, Filial>().ReverseMap();
            CreateMap<VendaDto, Venda>().ReverseMap();
        }
    }
}
