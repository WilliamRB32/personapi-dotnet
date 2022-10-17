using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public interface InterfazTelefonoRepository
    {
        Task<InterfazTelefonoRepository> CreateProductAsync(InterfazTelefonoRepository telefono);
        Task<bool> DeleteProductAsync(InterfazTelefonoRepository telefono);
        InterfazTelefonoRepository GetProductById(int id);
        IEnumerable<InterfazTelefonoRepository> GetProducts();
        Task<bool> UpdateProductAsync(InterfazTelefonoRepository telefono);
    }
}
