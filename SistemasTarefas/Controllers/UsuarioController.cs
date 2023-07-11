using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemasTarefas.Models;
using SistemasTarefas.Repositorios.Interfaces;

namespace SistemasTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorios _repo;
        public UsuarioController(IUsuarioRepositorios repo)
        {
            _repo = repo;
        }

        [HttpGet]

        public async Task<ActionResult<List<Usuarios>>> BuscarTodos()
        {
            List<Usuarios> model = await _repo.BuscarTodosUsuarios();
            return Ok(model);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Usuarios>> BuscarPorId(int id)
        {
            Usuarios model = await _repo.BuscarPorId(id);
            return Ok(model);
        }

        [HttpPost]

        public async Task<ActionResult<Usuarios>> Cadastrar([FromBody] Usuarios usuario)
        {
            Usuarios model = await _repo.Cadastrar(usuario);
            return model;

        }

        [HttpPut("{id}")]

        public async Task<ActionResult<Usuarios>> Atualizar([FromBody] Usuarios usuario, int id)
        {
            usuario.Id = id;
            Usuarios model = await _repo.Atualizar(usuario, id);
            return Ok(model);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<Usuarios>> Delete(int id)
        {
            bool model = await _repo.Apagar(id);
            return Ok(model);
        }


    }
}

