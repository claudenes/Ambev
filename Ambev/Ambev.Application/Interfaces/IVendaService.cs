using Ambev.Application.Dtos;

namespace Ambev.Application.Interfaces
{
    public interface IVendaService
    {
        VendaDto Create(VendaDto venda);
        VendaDto Read(Guid Id);
        VendaDto Update(VendaDto venda);
        VendaDto Delete(Guid Id);
        IEnumerable<VendaDto> ListAll();

    }
}
