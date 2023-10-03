using System;
using SistemasTarefas.Enums;

namespace SistemasTarefas.Models
{
	public class Tasks
    {
		public int Id { get; set; }

		public string? Name { get; set; }

		public string? Description { get; set; }

		public StatusTasks Status { get; set; }

		public int UsersId { get; set; }

		public virtual Users? User { get; set; }
	}
}

