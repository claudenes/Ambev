using Microsoft.AspNetCore.Mvc;
using Ambev.Application.Dtos;
using Ambev.Application.Interfaces;

namespace Ambev.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendaController : ControllerBase
    {
        private readonly IVendaService _service;
        public VendaController(IVendaService service)
        {
            _service = service;
        }
        [HttpGet]
        public Object ListAll()
        {
            return _service.ListAll();
        }
        [HttpPost]
        public Object Create([FromBody] VendaDto vendaDto)
        {
            return _service.Create(vendaDto);
        }
        [HttpPut]
        public Object Update([FromBody] VendaDto vendaDto)
        {
            return _service.Update(vendaDto);
        }
        [HttpDelete]
        public Object Delete(int Id)
        {
            return _service.Delete(Id);
        }
    }
}
