using Ambev.Application.Dtos;
using Ambev.Application.Interfaces;
using Ambev.Application.Services;
using Ambev.Domain.Entities;
using Ambev.Domain.Interfaces;
using Ambev.Domain.Tests.Common;
using Ambev.Domain.Tests.Domain;
using FluentAssertions;
using FluentValidation;
using NSubstitute;
using Xunit;

namespace Ambev.Domain.Tests.Application
{
    public class VendaServiceTest
    {
        private readonly IVendaRepository _repository;
        private readonly IVendaService _service;
        private readonly IVendaProdutoRepository _vendaProdutoRepository;
        private readonly IProdutoRepository _produtoRepository;

        public VendaServiceTest()
        {
            _repository = Substitute.For<IVendaRepository>();
            _vendaProdutoRepository = Substitute.For<IVendaProdutoRepository>();
            _produtoRepository = Substitute.For<IProdutoRepository>();
            _service = new VendaService(_repository, _vendaProdutoRepository, _produtoRepository, GenerateFakerMapper.AddMapperConfiguration());
        }
        [Fact]
        public void Constructor()
        {
            var result = new VendaService(_repository, _vendaProdutoRepository, _produtoRepository, GenerateFakerMapper.AddMapperConfiguration());
            result.Should().NotBeNull();

        }
        [Fact]
        public void Create() 
        {
            VendaDto VendaDto = GenerateFakerVendaDto.CreateVendaDto();
            Venda Venda = GenerateFakerVendaDto.CreateVenda(VendaDto);
            List<Venda> queryVenda = new();
            _repository.ReadAll().Where(x=>x.Id==VendaDto.Id).Returns(queryVenda);

            var result = _repository.Create(Venda).Returns(Venda);
            var result2 = _service.Create(VendaDto);

            result.Should().NotBeNull();
        }
        [Fact]
        public void Read()
        {
            VendaDto VendaDto = GenerateFakerVendaDto.CreateVendaDto();
            Venda Venda = GenerateFakerVendaDto.CreateVenda(VendaDto);
            List<Venda> queryVenda = new();
            _repository.ReadAll().Where(x => x.Id == VendaDto.Id).Returns(queryVenda);

            var result = _repository.ReadById(Venda.Id).Returns(Venda);
            var result2 = _service.Read(VendaDto.Id);

            result.Should().NotBeNull();
        }
        [Fact]
        public void Delete()
        {
            VendaDto VendaDto = GenerateFakerVendaDto.CreateVendaDto();
            Venda Venda = GenerateFakerVendaDto.CreateVenda(VendaDto);
            List<Venda> queryVenda = new();
            _repository.ReadAll().Where(x => x.Id == VendaDto.Id).Returns(queryVenda);

            var result = _repository.Delete(Venda.Id).Returns(Venda);
            var result2 = _service.Delete(VendaDto.Id);

            result.Should().NotBeNull();
        }
        [Fact]
        public void Update()
        {
            VendaDto VendaDto = GenerateFakerVendaDto.CreateVendaDto();
            Venda Venda = GenerateFakerVendaDto.CreateVenda(VendaDto);
            List<Venda> queryVenda = new();
            _repository.ReadAll().Where(x => x.Id == VendaDto.Id).Returns(queryVenda);

            var result = _repository.Update(Venda).Returns(Venda);
            var result2 = _service.Update(VendaDto);

            result.Should().NotBeNull();
        }
        [Fact]
        public void ListAll()
        {
            VendaDto VendaDto = GenerateFakerVendaDto.CreateVendaDto();
            IEnumerable<Venda> eVenda = GenerateFakerVendaDto.CreateIEnumerableVenda(VendaDto,1);
            ICollection<Venda> CVenda = eVenda.ToList();

            _repository.ReadAll().Returns(CVenda);


            var result = _service.ListAll();
            result.Should().NotBeNull();
        }
    }
}
