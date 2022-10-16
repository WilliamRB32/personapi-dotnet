using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public interface TelefonoRepository
    {
        Task<TelefonoRepository> CreateProductAsync(TelefonoRepository telefono);
        Task<bool> DeleteProductAsync(TelefonoRepository telefono);
        TelefonoRepository GetProductById(int id);
        IEnumerable<TelefonoRepository> GetProducts();
        Task<bool> UpdateProductAsync(TelefonoRepository telefono);
    }
}
