using Ambev.Application.Dtos;

namespace Ambev.Application.Interfaces
{
    public interface IVendaService
    {
        VendaDto Create(VendaDto venda);
        VendaDto Read(int Id);
        VendaDto Update(VendaDto venda);
        VendaDto Delete(int Id);
        IEnumerable<VendaDto> ListAll();

    }
}
