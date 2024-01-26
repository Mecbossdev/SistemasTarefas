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
    public class RegisterController : Controller
    {
        private readonly IRegisterRepositorios _repo;
        public RegisterController(IRegisterRepositorios repo)
        {
            _repo = repo;
        }

        [HttpGet]

        public async Task<ActionResult<List<Register>>> ListarTodas()
        {
            List<Register> model = await _repo.BuscarTodasTasks();
            return Ok(model);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Register>> BuscarPorId(int id)
        {
            Register model = await _repo.BuscarPorId(id);
            return Ok(model);
        }

        [HttpPost]

        public async Task<ActionResult<Register>> Cadastrar([FromBody] Register task)
        {
            Register model = await _repo.Cadastrar(task);
            return Ok(model);

        }

        [HttpPut("{id}")]

        public async Task<ActionResult<Register>> Atualizar([FromBody] Register task, int id)
        {
            task.Id = id;
            Register model = await _repo.Atualizar(task, id);
            return Ok(model);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<Register>> Delete(int id)
        {
            bool model = await _repo.Apagar(id);
            return Ok(model);
        }


    }
}

