using Microsoft.EntityFrameworkCore;
using PortalReclutamiento.Models;

namespace PortalReclutamiento.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Oferta> Ofertas { get; set; }
        public DbSet<Aplicacion> Aplicaciones { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
    }
}