using Ambev.Application.Dtos;
using Ambev.Application.Interfaces;
using Ambev.Domain.Entities;
using Ambev.Domain.Interfaces;
using AutoMapper;

namespace Ambev.Application.Services
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _repository;
        private readonly IMapper _mapper;

        public VendaService(IVendaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public VendaDto Create(VendaDto venda)
        {
            return _mapper.Map<VendaDto>(_repository.Create(_mapper.Map<Venda>(venda)));
        }

        public VendaDto Delete(int Id)
        {
            return _mapper.Map<VendaDto>(_repository.Delete(Id));
        }

        public IEnumerable<VendaDto> ListAll()
        {
            return _mapper.Map<IEnumerable<VendaDto>>(_repository.ReadAll());
        }

        public VendaDto Read(int Id)
        {
            return _mapper.Map<VendaDto>(_repository.ReadById(Id));
        }

        public VendaDto Update(VendaDto venda)
        {
            return _mapper.Map<VendaDto>(_repository.Update(_mapper.Map<Venda>(venda)));
        }
    }
}
