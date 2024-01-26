using System;
using SistemasTarefas.Models;

namespace SistemasTarefas.Repositorios.Interfaces
{
	public interface IRegisterRepositorios
	{
		Task<List<Register>> BuscarTodasTasks();

		Task<Register> BuscarPorId(int id);

		Task<Register> Cadastrar(Register task);

		Task<Register> Atualizar(Register task, int id);

		Task<bool> Apagar(int id);
    } 
}

