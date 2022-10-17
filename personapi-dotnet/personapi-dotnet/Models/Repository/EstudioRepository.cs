using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;
using personapi_dotnet.Models.Repository;

namespace DemoAPI.Models.Repository
{
    public class EstudioRepository : InterfazEstudioRepository
    {
        protected readonly persona_dbContext _context;
        public EstudioRepository(persona_dbContext context) => _context = context;

        public IEnumerable<Estudio> GetProducts()
        {
            return _context.Estudios.ToList();
        }

        public Estudio GetProductById(int id)
        {
            return _context.Estudios.Find(id);
        }
        public async Task<Estudio> CreateProductAsync(Estudio estudio)
        {
            await _context.Set<Estudio>().AddAsync(estudio);
            await _context.SaveChangesAsync();
            return estudio;
        }

        public async Task<bool> UpdateProductAsync(Estudio estudio)
        {
            _context.Entry(estudio).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteProductAsync(Estudio estudio)
        {
            //var entity = await GetByIdAsync(id);
            if (estudio is null)
            {
                return false;
            }
            _context.Set<Estudio>().Remove(estudio);
            await _context.SaveChangesAsync();

            return true;
        }

        public Task<Estudio> CrearEstudio(Estudio estudio)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarEstudio(Estudio estudio)
        {
            throw new NotImplementedException();
        }

        public Estudio GetEstudioPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Estudio> GetEstudio()
        {
            throw new NotImplementedException();
        }

        public Task<bool> ActualizarEstudio(Estudio product)
        {
            throw new NotImplementedException();
        }
    }
}