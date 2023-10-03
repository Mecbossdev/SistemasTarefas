using System;
using Microsoft.EntityFrameworkCore;
using SistemasTarefas.Data;
using SistemasTarefas.Models;
using SistemasTarefas.Repositorios.Interfaces;

namespace SistemasTarefas.Repositorios
{
	public class UsuarioRepositorios : IUsuarioRepositorios
	{
        private readonly UsuariosDbContext _context;
        public UsuarioRepositorios(UsuariosDbContext context)
		{
            _context = context;
		}

        public async Task<List<Users>> BuscarTodosUsuarios()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<Users> BuscarPorId(int id)
        {
            Users? valor = await _context.Users.FirstOrDefaultAsync(h => h.Id == id);

            if (valor == null)
            {
                throw new NotImplementedException();
            }

            return valor;

            
        }

        public async Task<Users> Cadastrar(Users user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;

        }

        public async Task<Users> Atualizar(Users user, int id)
        {
            Users usuarioId = await BuscarPorId(id);

            if (usuarioId == null)
            {
                throw new NotImplementedException();
            }

            usuarioId.Name = user.Name;
            usuarioId.Email = user.Email;
            usuarioId.NumberPhone = user.NumberPhone;
            usuarioId.Tarefas = user.Tarefas;

            _context.Users.Update(usuarioId);
            await _context.SaveChangesAsync();

            return usuarioId;
        }

        public async Task<bool> Apagar(int id)
        {
            Users usuarioId = await BuscarPorId(id);

            if (usuarioId == null)
            {
                throw new NotImplementedException();
            }

            _context.Users.Remove(usuarioId);
            await _context.SaveChangesAsync();
            return true;
        }



    }
}

