using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public interface ProfesionRepository
    {
        Task<ProfesionRepository> CrearProfesion(ProfesionRepository profesion);
        Task<bool> EliminarProfesion(ProfesionRepository profesion);
        ProfesionRepository GetProfesionPorId(int id);
        IEnumerable<ProfesionRepository> GetProfesiones();
        Task<bool> ActualizarProfesion(ProfesionRepository profesion);
    }
}
