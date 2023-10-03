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
    public class TaskController : Controller
    {
        private readonly ITasksRepositorios _repo;
        public TaskController(ITasksRepositorios repo)
        {
            _repo = repo;
        }

        [HttpGet]

        public async Task<ActionResult<List<Tasks>>> ListarTodas()
        {
            List<Tasks> model = await _repo.BuscarTodasTasks();
            return Ok(model);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Tasks>> BuscarPorId(int id)
        {
            Tasks model = await _repo.BuscarPorId(id);
            return Ok(model);
        }

        [HttpPost]

        public async Task<ActionResult<Tasks>> Cadastrar([FromBody] Tasks task)
        {
            Tasks model = await _repo.Cadastrar(task);
            return Ok(model);

        }

        [HttpPut("{id}")]

        public async Task<ActionResult<Tasks>> Atualizar([FromBody] Tasks task, int id)
        {
            task.Id = id;
            Tasks model = await _repo.Atualizar(task, id);
            return Ok(model);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<Tasks>> Delete(int id)
        {
            bool model = await _repo.Apagar(id);
            return Ok(model);
        }


    }
}

