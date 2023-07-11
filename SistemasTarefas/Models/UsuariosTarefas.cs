using System;
namespace SistemasTarefas.Models
{
	public class UsuariosTarefas
	{
		public int UsuariosId { get; set; }

		public Usuarios? Usuarios { get; set; }

		public int TarefasId { get; set; }

		public Tarefas? Tarefas { get; set; }
	}
}

