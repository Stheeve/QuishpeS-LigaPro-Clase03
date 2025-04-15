using QuishpeS_LigaPro_Clase03.Interface;
using QuishpeS_LigaPro_Clase03.Models;

namespace QuishpeS_LigaPro_Clase03.Repositorios
{
    public class EquipoRepository : IEquipoRepository
    {
        public bool ActualizaEquipo()
        {
            throw new NotImplementedException();
        }

        public bool CrearEquipo()
        {
            throw new NotImplementedException();
        }

        public Equipo DevuelveInfoEquipo(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.Where(item => item.Id == Id).First();
            return equipo;
        
        }

    

        public List<Equipo> DevuelveListadoEquipos()
        {


            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                Detalles = "La LDU es el club de fútbol más exitoso de Ecuador, con 13 títulos nacionales, cinco internacionales y nueve regionales. En 2023, la LDU ganó la Copa Sudamericana y la Serie A de Ecuador.",
                Id = 1,
                Nombre = "Ldu",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0,
                ImagenUrl= "/Imagenes/Liga_Deportiva_Universitaria_de_Quito.png"



            };
            equipos.Add(ldu);

            Equipo bsc = new Equipo
            {
                Detalles = "El Barcelona Sporting Club (BSC) es un equipo de fútbol ecuatoriano fundado en 1925. Es uno de los clubes más exitosos del país y juega en la Serie A, la máxima categoría del fútbol ecuatoriano.",
                Id = 2,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 1,
                PartidosPerdidos = 8,
                ImagenUrl="/Imagenes/Barcelona_Sporting_Club_Logo.png"



            };
            equipos.Add(bsc);

            Equipo mushucruna = new Equipo
            {
                Detalles = "Mushuc Runa Sporting Club es un club de fútbol profesional ecuatoriano con sede en Ambato . Fue fundado el 2 de enero de 2003. Actualmente juega en la Serie A ecuatoriana . El club se fundó ",
                Id = 3,
                Nombre = "Mushuc Runa ",
                PartidosJugados = 10,
                PartidosGanados = 2,
                PartidosEmpatados = 6,
                PartidosPerdidos = 2,
                ImagenUrl = "/Imagenes/Mushuc_Runa_SC.png"



            };
            equipos.Add(mushucruna);

            Equipo nacional = new Equipo
            {
                Detalles = "El Club Deportivo El Nacional es un equipo de fútbol ecuatoriano con sede en Quito. Es uno de los clubes más laureados del país.",
                Id = 4,
                Nombre = "El Nacional",
                PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosEmpatados = 2,
                PartidosPerdidos = 3,
                ImagenUrl = "/Imagenes/CD El Nacional.png"



            };
            equipos.Add(nacional);


            Equipo emelec = new Equipo
            {
                Detalles = "El Club Sport Emelec es un club deportivo creado en 1925 y fundado el 28 de abril de 1929 por el estadounidense George Capwell en Guayaquil.",
                Id = 5,
                Nombre = "Emelec",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados =0,
                PartidosPerdidos = 9,
                ImagenUrl = "/Imagenes/EscudoCSEmelec.png"



            };
            equipos.Add(emelec);


            Equipo aucas = new Equipo
            {
                Detalles = "El club Sociedad Deportiva Aucas, conocido como Aucas, tiene academias de fútbol para niños y niñas. ",
                Id = 6,
                Nombre = "Aucas",
                PartidosJugados = 10,
                PartidosGanados = 2,
                PartidosEmpatados = 6,
                PartidosPerdidos = 2,
                ImagenUrl = "/Imagenes/559X580.png"



            };
            equipos.Add(aucas);




            return equipos;
        }

        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }
    }
}
