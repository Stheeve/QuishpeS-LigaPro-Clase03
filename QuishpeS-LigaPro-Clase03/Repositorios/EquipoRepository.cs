using QuishpeS_LigaPro_Clase03.Interface;
using QuishpeS_LigaPro_Clase03.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuishpeS_LigaPro_Clase03.Repositorios
{
    public class EquipoRepository : IEquipoRepository
    {
        
        private static List<Equipo> _equipos;

        
        public EquipoRepository()
        {
            if (_equipos == null)
            {
                _equipos = InicializaEquipos();
            }
        }

        public List<Equipo> DevuelveListadoEquipos()
        {
            return _equipos;
        }

        public Equipo DevuelveInfoEquipo(int Id)
        {
            return _equipos.FirstOrDefault(e => e.Id == Id);
        }


        public bool ActualizaEquipo(int Id, int ganados, int empatados, int perdidos)
        {
            
            var equipos = DevuelveListadoEquipos();

            
            var equipo = equipos.FirstOrDefault(e => e.Id == Id);

            if (equipo == null)
            {
                return false; 
            }

          
            equipo.PartidosGanados = ganados;
            equipo.PartidosEmpatados = empatados;
            equipo.PartidosPerdidos = perdidos;
            equipo.PartidosJugados = ganados + empatados + perdidos;

           
            return true;
        }



       
        public bool CrearEquipo(Equipo equipo)
        {
           
            throw new NotImplementedException();
        }

        public bool EliminarEquipo(int id)
        {
         
            throw new NotImplementedException();
        }

 
        private List<Equipo> InicializaEquipos()
        {
            return new List<Equipo>
            {
                new Equipo
                {
                    Id = 1,
                    Nombre = "Ldu",
                    Detalles = "La Liga Deportiva Universitaria de Quito (LDU) tiene un salón pequeño en su sede deportiva, el Country Club de LDU, en Pomasqui",
                    PartidosJugados = 10,
                    PartidosGanados = 10,
                    PartidosEmpatados = 0,
                    PartidosPerdidos = 0,
                    ImagenUrl = "/Imagenes/Liga_Deportiva_Universitaria_de_Quito.png"
                },
                new Equipo
                {
                    Id = 2,
                    Nombre = "Barcelona",
                    Detalles = "El Barcelona Sporting Club (BSC) es un club de fútbol ecuatoriano fundado en 1925 en Guayaquil",
                    PartidosJugados = 10,
                    PartidosGanados = 1,
                    PartidosEmpatados = 1,
                    PartidosPerdidos = 8,
                    ImagenUrl = "/Imagenes/Barcelona_Sporting_Club_Logo.png"
                },
                new Equipo
                {
                    Id = 3,
                    Nombre = "Mushuc Runa",
                    Detalles = "Mushuc Runa Sporting Club es un club de fútbol profesional ecuatoriano con sede en Ambato .",
                    PartidosJugados = 10,
                    PartidosGanados = 2,
                    PartidosEmpatados = 6,
                    PartidosPerdidos = 2,
                    ImagenUrl = "/Imagenes/Mushuc_Runa_SC.png"
                },
                new Equipo
                {
                    Id = 4,
                    Nombre = "El Nacional",
                    Detalles = "El Club Deportivo El Nacional, más conocido como El Nacional, es una entidad deportiva ecuatoriana con sede en la ciudad de Quito.",
                    PartidosJugados = 10,
                    PartidosGanados = 5,
                    PartidosEmpatados = 2,
                    PartidosPerdidos = 3,
                    ImagenUrl = "/Imagenes/CD El Nacional.png"
                },
                new Equipo
                {
                    Id = 5,
                    Nombre = "Emelec",
                    Detalles = "El Club Sport Emelec es un club deportivo creado en 1925 y fundado el 28 de abril de 1929 por el estadounidense George Capwell en Guayaquil .",
                    PartidosJugados = 10,
                    PartidosGanados = 1,
                    PartidosEmpatados = 0,
                    PartidosPerdidos = 9,
                    ImagenUrl = "/Imagenes/EscudoCSEmelec.png"
                },
                new Equipo
                {
                    Id = 6,
                    Nombre = "Aucas",
                    Detalles = "El club Sociedad Deportiva Aucas, o Aucas, tiene academias de fútbol en Ecuador.",
                    PartidosJugados = 10,
                    PartidosGanados = 2,
                    PartidosEmpatados = 6,
                    PartidosPerdidos = 2,
                    ImagenUrl = "/Imagenes/559X580.png"
                }
            };
        }
    }
}

