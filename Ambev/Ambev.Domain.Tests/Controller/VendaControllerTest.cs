using FluentAssertions;
using NSubstitute;
using Ambev.API.Controllers;
using Ambev.Application.Dtos;
using Ambev.Application.Interfaces;
using Ambev.Domain.Tests.Domain;
using Xunit;

namespace Ambev.Domain.Tests.Controller
{
    public class VendaControllerTest
    {
        private readonly IVendaService _service;
        private readonly VendaController _controller;
        public VendaControllerTest()
        {
            _service = Substitute.For<IVendaService>();
            _controller = new VendaController(_service);
        }
        [Fact]
        public void Constructor()
        {
            var result = new VendaController(_service);
            VendaDto dto = GenerateFakerVendaDto.CreateVendaDto();
            result.Should().NotBeNull();
        }
        [Fact]
        public void ListAll()
        {
            VendaDto dto = GenerateFakerVendaDto.CreateVendaDto();
            var result = _controller.ListAll();
            result.Should().NotBeNull();
        }
        [Fact]
        public void Create()
        {
            VendaDto dto = GenerateFakerVendaDto.CreateVendaDto();
            var result = _controller.Create(dto);
            result.Should().BeNull();
        }
        [Fact]
        public void Update()
        {
            VendaDto dto = GenerateFakerVendaDto.CreateVendaDto();
            var result = _controller.Update(dto);
        }
        [Fact]
        public void Delete()
        {
            VendaDto dto = GenerateFakerVendaDto.CreateVendaDto();
            var result = _controller.Delete(dto.Id);
            result.Should().BeNull();
        }
        
    }
}
