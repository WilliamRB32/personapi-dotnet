using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;
using personapi_dotnet.Models.Repository;

namespace DemoAPI.Models.Repository
{
    public class PersonaRepository : InterfazPersonaRepository
    {
        protected readonly persona_dbContext _context;
        public PersonaRepository(persona_dbContext context) => _context = context;


        public Task<Persona> CrearPersona(Persona persona)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarPersona(Persona persona)
        {
            throw new NotImplementedException();
        }

        public Persona GetPersonaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Persona> GetPersonas()
        {
            throw new NotImplementedException();
        }

        public Task<bool> ActualizarPersona(Persona persona)
        {
            throw new NotImplementedException();
        }
    }
}