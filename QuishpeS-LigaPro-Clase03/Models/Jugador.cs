using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuishpeS_LigaPro_Clase03.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int NumCamiseta { get; set; }
        public int Goles { get; set; }
        public int Asistencias { get; set; }
        public int Sueldo { get; set; }
        public int EquipoId { get; set; }
        [ForeignKey("EquipoId")]
        public Equipo? Equipo { get; set; }



    }
}
