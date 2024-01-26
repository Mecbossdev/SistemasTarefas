using System;
using SistemasTarefas.Models;

namespace SistemasTarefas.Repositorios.Interfaces
{
	public interface IUsersRepositorios
	{
		Task<List<Users>> BuscarTodosUsuarios();

		Task<Users> BuscarPorId(int id);

		Task<Users> Cadastrar(Users user);

		Task<Users> Atualizar(Users user, int id);

		Task<bool> Apagar(int id);
    } 
}

