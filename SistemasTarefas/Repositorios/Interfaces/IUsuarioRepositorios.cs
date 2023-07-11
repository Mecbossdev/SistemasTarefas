using System;
using SistemasTarefas.Models;

namespace SistemasTarefas.Repositorios.Interfaces
{
	public interface IUsuarioRepositorios
	{
		Task<List<Usuarios>> BuscarTodosUsuarios();

		Task<Usuarios> BuscarPorId(int id);

		Task<Usuarios> Cadastrar(Usuarios usuario);

		Task<Usuarios> Atualizar(Usuarios usuario, int id);

		Task<bool> Apagar(int id);
    } 
}

