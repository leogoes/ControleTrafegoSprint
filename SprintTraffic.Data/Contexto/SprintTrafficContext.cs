using Microsoft.EntityFrameworkCore;
using SprintTraffic.Domain.Entities;
using System;

namespace SprintTraffic.Infrastructure.Data.Contexto
{
    public class SprintTrafficContext : DbContext
    {
        public SprintTrafficContext(DbContextOptions<SprintTrafficContext> options)
            :base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Squad> Squads { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasOne<Squad>(s => s.Squad)
                .WithOne(u => u.Usuario)
                .HasForeignKey<Squad>(u => u.UsuarioId);


            base.OnModelCreating(modelBuilder);

        }
    }
}
