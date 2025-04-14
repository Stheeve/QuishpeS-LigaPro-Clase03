using Microsoft.AspNetCore.Mvc;
using QuishpeS_LigaPro_Clase03.Models;
using QuishpeS_LigaPro_Clase03.Repositorios;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuishpeS_LigaPro_Clase03.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult ListaEquipos()
        {
           EquipoRepository repository = new EquipoRepository();
            var equipos = repository.DevuelveListadoEquipos();
            return View(equipos);
        }

        public IActionResult Edit(int Id)
        {
            EquipoRepository repository = new EquipoRepository();
            var equipo = repository.DevuelveInfoEquipo(Id);
            return View(equipo);
        }
      

            
    }
}

