using System;
namespace SistemasTarefas.Models
{
	public class Usuarios
	{
		public int Id { get; set; }

		public string? Name { get; set; }

		public string? Email { get; set; }

		public int NumberPhone { get; set; }

		public List<Tarefas>? Tarefas { get; set; }
	}
}

