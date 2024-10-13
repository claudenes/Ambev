using AutoMapper;
using Ambev.Application.Dtos;
using Ambev.Domain.Entities;

namespace Ambev.Domain.Tests.Common
{
    public class GenerateFakerMapper
    {
        public static IMapper AddMapperConfiguration()
        {
            var autoMapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cliente, ClienteDto>().ReverseMap();
                cfg.CreateMap<Produto, ProdutoDto>().ReverseMap();
                cfg.CreateMap<VendaDto, VendaDto>().ReverseMap();
                cfg.CreateMap<Filial, FilialDto>().ReverseMap();

            });
            IMapper mapper = new Mapper(autoMapperConfig);
            return mapper;
        }
    }
}
