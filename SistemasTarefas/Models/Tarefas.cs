using System;
namespace SistemasTarefas.Models
{
	public class Tarefas
	{
		public int Id { get; set; }

		public string? Name { get; set; }

		public string? Description { get; set; }

		public int UsuariosId { get; set; }

		public Usuarios? Usuarios { get; set; }
	}
}

