using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public interface EstudioRepository
    {
        Task<Estudio> CrearEstudio(Estudio estudio);
        Task<bool> EliminarEstudio(Estudio estudio);
        Estudio GetEstudioPorId(int id);
        IEnumerable<Estudio> GetEstudio();
        Task<bool> ActualizarEstudio(Estudio product);
    }
}
