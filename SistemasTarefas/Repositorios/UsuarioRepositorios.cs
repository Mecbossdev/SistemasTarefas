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

        public async Task<List<Usuarios>> BuscarTodosUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<Usuarios> BuscarPorId(int id)
        {
            Usuarios? valor = await _context.Usuarios.FirstOrDefaultAsync(h => h.Id == id);

            if (valor == null)
            {
                throw new NotImplementedException();
            }

            return valor;

            
        }

        public async Task<Usuarios> Cadastrar(Usuarios usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();

            return usuario;

        }

        public async Task<Usuarios> Atualizar(Usuarios usuario, int id)
        {
            Usuarios usuarioId = await BuscarPorId(id);

            if (usuarioId == null)
            {
                throw new NotImplementedException();
            }

            usuarioId.Name = usuario.Name;
            usuarioId.Email = usuario.Email;
            usuarioId.NumberPhone = usuario.NumberPhone;
            usuarioId.Tarefas = usuario.Tarefas;

            _context.Usuarios.Update(usuarioId);
            await _context.SaveChangesAsync();

            return usuarioId;
        }

        public async Task<bool> Apagar(int id)
        {
            Usuarios usuarioId = await BuscarPorId(id);

            if (usuarioId == null)
            {
                throw new NotImplementedException();
            }

            _context.Remove(id);
            await _context.SaveChangesAsync();
            return true;
        }



    }
}

