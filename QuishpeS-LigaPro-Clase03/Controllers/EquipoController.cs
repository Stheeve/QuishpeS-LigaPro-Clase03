using Microsoft.AspNetCore.Mvc;
using QuishpeS_LigaPro_Clase03.Interface;
using QuishpeS_LigaPro_Clase03.Models;

namespace QuishpeS_LigaPro_Clase03.Controllers
{
    public class EquipoController : Controller
    {
        private readonly IEquipoRepository _equipoRepository;

        
        public EquipoController(IEquipoRepository equipoRepository)
        {
            _equipoRepository = equipoRepository;
        }

        
        public IActionResult ListaEquipos()
        {
            var equipos = _equipoRepository.DevuelveListadoEquipos();
            return View(equipos); 
        }

        
        public IActionResult Details(int id)
        {
            var equipo = _equipoRepository.DevuelveInfoEquipo(id);
            if (equipo == null)
            {
                return NotFound();
            }

            return View(equipo); 
        }

        public IActionResult Edit(int id)
        {
            var equipo = _equipoRepository.DevuelveInfoEquipo(id);
            if (equipo == null)
            {
                return NotFound(); 
            }

            return View(equipo); +
        }

     +
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, int partidosGanados, int partidosEmpatados, int partidosPerdidos)
        {
            if (ModelState.IsValid)
            {
                bool updated = _equipoRepository.ActualizaEquipo(id, partidosGanados, partidosEmpatados, partidosPerdidos);

                if (updated)
                {
                    return RedirectToAction(nameof(ListaEquipos)); 
                }
                else
                {
                    return NotFound(); 
                }
            }

           
            return View();
        }
    }
}

