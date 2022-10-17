using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public class TelefonoRepository : InterfazTelefonoRepository
    {
        protected readonly persona_dbContext _context;
        public TelefonoRepository(persona_dbContext context) => _context = context;

        public Task<InterfazTelefonoRepository> CreateProductAsync(InterfazTelefonoRepository telefono)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProductAsync(InterfazTelefonoRepository telefono)
        {
            throw new NotImplementedException();
        }

        public InterfazTelefonoRepository GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InterfazTelefonoRepository> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProductAsync(InterfazTelefonoRepository telefono)
        {
            throw new NotImplementedException();
        }
    }
}
