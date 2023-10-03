using System;
using Microsoft.EntityFrameworkCore;
using SistemasTarefas.Data;
using SistemasTarefas.Models;
using SistemasTarefas.Repositorios.Interfaces;

namespace SistemasTarefas.Repositorios
{
	public class TasksRepositorios : ITasksRepositorios
	{
        private readonly UsuariosDbContext _context;
        public TasksRepositorios(UsuariosDbContext context)
		{
            _context = context;
		}

        public async Task<List<Tasks>> BuscarTodasTasks()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<Tasks> BuscarPorId(int id)
        {
            Tasks? valor = await _context.Tasks.FirstOrDefaultAsync(h => h.Id == id);

            if (valor == null)
            {
                throw new NotImplementedException();
            }

            return valor;

            
        }

        public async Task<Tasks> Cadastrar(Tasks task)
        {
            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();

            return task;

        }

        public async Task<Tasks> Atualizar(Tasks task, int id)
        {
            Tasks taskId= await BuscarPorId(id);

            if (taskId == null)
            {
                throw new NotImplementedException();
            }

            taskId.Name = task.Name;
            taskId.Description = task.Description;
            taskId.Status = task.Status;
            taskId.UsersId = task.UsersId;

            _context.Tasks.Update(taskId);
            await _context.SaveChangesAsync();

            return taskId;
        }

        public async Task<bool> Apagar(int id)
        {
            Tasks taskId = await BuscarPorId(id);

            if (taskId == null)
            {
                throw new NotImplementedException();
            }

            _context.Tasks.Remove(taskId);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

