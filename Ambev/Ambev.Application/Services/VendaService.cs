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
        private readonly IVendaProdutoRepository _vendaProdutoRepository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public VendaService(IVendaRepository repository, IVendaProdutoRepository vendaProdutoRepository,IProdutoRepository produtoRepository, IMapper mapper)
        {
            _repository = repository;
            _vendaProdutoRepository = vendaProdutoRepository;
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public VendaDto Create(VendaDto venda)
        {
            venda.ValorTotalVenda = CalculaValorTotal(venda.VendaProduto);
            var results = _mapper.Map<VendaDto>(_repository.Create(_mapper.Map<Venda>(venda)));
            if(results != null)
            {
                foreach(var item in venda.VendaProduto)
                {
                    item.VendaId = results.Id;
                    _vendaProdutoRepository.Create(_mapper.Map<VendaProduto>(item));
                }
            }

            return results;
        }
        private decimal CalculaValorTotal(List<VendaProdutoDto> vendaProdutoDto)
        {
            decimal valortotal = 0;
            foreach (var item in vendaProdutoDto)
            {
                valortotal = valortotal + _produtoRepository.ReadById(item.ProdutoId).Valor;
            }
            return valortotal;
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
