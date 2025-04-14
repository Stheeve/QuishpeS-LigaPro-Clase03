using QuishpeS_LigaPro_Clase03.Models;

namespace QuishpeS_LigaPro_Clase03.Interface
{
    public interface IEquipoRepository
    {
        List<Equipo> DevuelveListadoEquipos();
        Equipo DevuelveInfoEquipo(int Id);
        bool CrearEquipo();
        bool ActualizaEquipo();
        bool EliminarEquipo();


    }
}
