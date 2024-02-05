using BlazorServerBienesRaices.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerBienesRaices.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //Agregar modelos
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Propiedad> Propiedad { get; set; }
        public DbSet<ImagenPropiedad> ImagenPropiedad { get; set; }

    }
}