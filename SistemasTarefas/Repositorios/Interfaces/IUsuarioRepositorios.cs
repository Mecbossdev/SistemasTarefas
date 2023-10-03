using System;
using SistemasTarefas.Models;

namespace SistemasTarefas.Repositorios.Interfaces
{
	public interface IUsuarioRepositorios
	{
		Task<List<Users>> BuscarTodosUsuarios();

		Task<Users> BuscarPorId(int id);

		Task<Users> Cadastrar(Users usuario);

		Task<Users> Atualizar(Users usuario, int id);

		Task<bool> Apagar(int id);
    } 
}

