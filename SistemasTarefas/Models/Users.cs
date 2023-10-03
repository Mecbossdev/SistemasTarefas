using System;
namespace SistemasTarefas.Models
{
	public class Users
	{
		public int Id { get; set; }

		public string? Name { get; set; }

		public string? Email { get; set; }

		public int NumberPhone { get; set; }

		public List<Tasks>? Tasks { get; set; }
	}
}

