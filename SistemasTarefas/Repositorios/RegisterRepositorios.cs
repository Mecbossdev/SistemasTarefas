using System;
using Microsoft.EntityFrameworkCore;
using SistemasTarefas.Data;
using SistemasTarefas.Models;
using SistemasTarefas.Repositorios.Interfaces;

namespace SistemasTarefas.Repositorios
{
	public class RegisterRepositorios : IRegisterRepositorios
	{
        private readonly UsuariosDbContext _context;
        public RegisterRepositorios(UsuariosDbContext context)
		{
            _context = context;
		}

        public async Task<List<Register>> BuscarTodasTasks()
        {
            return await _context.Registers.ToListAsync();
        }

        public async Task<Register> BuscarPorId(int id)
        {
            Register? valor = await _context.Registers.FirstOrDefaultAsync(h => h.Id == id);

            if (valor == null)
            {
                throw new NotImplementedException();
            }

            return valor;

            
        }

        public async Task<Register> Cadastrar(Register task)
        {
            await _context.Registers.AddAsync(task);
            await _context.SaveChangesAsync();

            return task;

        }

        public async Task<Register> Atualizar(Register task, int id)
        {
            Register taskId= await BuscarPorId(id);

            if (taskId == null)
            {
                throw new NotImplementedException();
            }

            taskId.Name = task.Name;
            taskId.Email = task.Email;
            taskId.Password = task.Password;
            taskId.UsersId = task.UsersId;

            _context.Registers.Update(taskId);
            await _context.SaveChangesAsync();

            return taskId;
        }

        public async Task<bool> Apagar(int id)
        {
            Register taskId = await BuscarPorId(id);

            if (taskId == null)
            {
                throw new NotImplementedException();
            }

            _context.Registers.Remove(taskId);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

