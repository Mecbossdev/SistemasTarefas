﻿using System;
namespace SistemasTarefas.Models
{
	public class Users
	{
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Register? Register { get; set; }
    }
}

