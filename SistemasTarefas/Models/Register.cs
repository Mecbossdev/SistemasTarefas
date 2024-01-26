using System;
using SistemasTarefas.Enums;

namespace SistemasTarefas.Models
{
	public class Register
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int UsersId { get; set; }
        public Users? User { get; set; }
    }
}

