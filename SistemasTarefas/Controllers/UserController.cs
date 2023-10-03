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
    public class UserController : Controller
    {
        private readonly IUsuarioRepositorios _repo;
        public UserController(IUsuarioRepositorios repo)
        {
            _repo = repo;
        }

        [HttpGet]

        public async Task<ActionResult<List<Users>>> BuscarTodos()
        {
            List<Users> model = await _repo.BuscarTodosUsuarios();
            return Ok(model);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Users>> BuscarPorId(int id)
        {
            Users model = await _repo.BuscarPorId(id);
            return Ok(model);
        }

        [HttpPost]

        public async Task<ActionResult<Users>> Cadastrar([FromBody] Users usuario)
        {
            Users model = await _repo.Cadastrar(usuario);
            return Ok(model);

        }

        [HttpPut("{id}")]

        public async Task<ActionResult<Users>> Atualizar([FromBody] Users usuario, int id)
        {
            usuario.Id = id;
            Users model = await _repo.Atualizar(usuario, id);
            return Ok(model);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<Users>> Delete(int id)
        {
            bool model = await _repo.Apagar(id);
            return Ok(model);
        }


    }
}

