using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuishpeS_LigaPro_Clase03.Models;

namespace QuishpeS_LigaPro_Clase03.Data
{
    public class QuishpeS_LigaPro_Clase03Context : DbContext
    {
        public QuishpeS_LigaPro_Clase03Context (DbContextOptions<QuishpeS_LigaPro_Clase03Context> options)
            : base(options)
        {
        }

        public DbSet<QuishpeS_LigaPro_Clase03.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<QuishpeS_LigaPro_Clase03.Models.Equipo> Equipo  { get; set; } = default!;

    }
}
