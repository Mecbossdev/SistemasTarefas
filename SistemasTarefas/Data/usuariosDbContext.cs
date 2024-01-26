using System;
using Microsoft.EntityFrameworkCore;
using SistemasTarefas.Data.Map;
using SistemasTarefas.Models;

namespace SistemasTarefas.Data
{
	public class UsuariosDbContext : DbContext
	{
		public DbSet<Users> Users { get; set; }

		public DbSet<Register> Registers { get; set; }

		public UsuariosDbContext(DbContextOptions<UsuariosDbContext> options) : base(options)
		{
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersMap());
            modelBuilder.ApplyConfiguration(new RegisterMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}

