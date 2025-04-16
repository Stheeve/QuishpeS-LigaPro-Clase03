using QuishpeS_LigaPro_Clase03.Models;
using System.Collections.Generic;

namespace QuishpeS_LigaPro_Clase03.Interface
{
    public interface IEquipoRepository
    {
        List<Equipo> DevuelveListadoEquipos();
        Equipo DevuelveInfoEquipo(int Id);
        bool CrearEquipo(Equipo equipo);
        bool ActualizaEquipo(int id, int ganados, int empatados, int perdidos);
        bool EliminarEquipo(int id);
    }
}
