using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SistemaGestionEscuelas.Models
{
    public class EscuelaContext : DbContext
    {
        public EscuelaContext(DbContextOptions<EscuelaContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
    }
}