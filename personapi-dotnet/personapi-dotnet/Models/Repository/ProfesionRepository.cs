using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public class ProfesionRepository : InterfazProfesionRepository
    {
        protected readonly persona_dbContext _context;
        public ProfesionRepository(persona_dbContext context) => _context = context;

        public Task<bool> ActualizarProfesion(Profesion profesion)
        {
            throw new NotImplementedException();
        }

        public Task<Profesion> CrearProfesion(Profesion profesion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarProfesion(Profesion profesion)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Profesion> GetProfesiones()
        {
            throw new NotImplementedException();
        }

        public Profesion GetProfesionPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
