using System;
using Microsoft.EntityFrameworkCore;
using SistemasTarefas.Data.Map;
using SistemasTarefas.Models;

namespace SistemasTarefas.Data
{
	public class UsuariosDbContext : DbContext
	{
		public DbSet<Usuarios> Usuarios { get; set; }

		public DbSet<Tarefas> Tarefas { get; set; }

		public UsuariosDbContext(DbContextOptions<UsuariosDbContext> options) : base(options)
		{
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.ApplyConfiguration(new UsuarioMap());
			modelBuilder.ApplyConfiguration(new TarefaMap());
			modelBuilder.Entity<UsuariosTarefas>(entity =>
			 entity.HasKey(e => new { e.UsuariosId, e.TarefasId }));
            base.OnModelCreating(modelBuilder);
        }
    }
}

