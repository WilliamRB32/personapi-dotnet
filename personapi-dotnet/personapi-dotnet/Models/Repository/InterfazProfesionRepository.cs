using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public interface InterfazProfesionRepository
    {
        Task<Profesion> CrearProfesion(Profesion profesion);
        Task<bool> EliminarProfesion(Profesion profesion);
        Profesion GetProfesionPorId(int id);
        IEnumerable<Profesion> GetProfesiones();
        Task<bool> ActualizarProfesion(Profesion profesion);
    }
}
