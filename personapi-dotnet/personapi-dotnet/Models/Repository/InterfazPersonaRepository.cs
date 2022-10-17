using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public interface InterfazPersonaRepository
    {   
        Task<Persona> CrearPersona(Persona persona);
        Task<bool> EliminarPersona(Persona persona);
        Persona GetPersonaPorId(int id);
        IEnumerable<Persona> GetPersonas();
        Task<bool> ActualizarPersona(Persona persona);
    }
}
