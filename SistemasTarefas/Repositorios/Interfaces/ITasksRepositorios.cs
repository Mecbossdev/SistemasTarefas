using System;
using SistemasTarefas.Models;

namespace SistemasTarefas.Repositorios.Interfaces
{
	public interface ITasksRepositorios
	{
		Task<List<Tasks>> BuscarTodasTasks();

		Task<Tasks> BuscarPorId(int id);

		Task<Tasks> Cadastrar(Tasks task);

		Task<Tasks> Atualizar(Tasks task, int id);

		Task<bool> Apagar(int id);
    } 
}

