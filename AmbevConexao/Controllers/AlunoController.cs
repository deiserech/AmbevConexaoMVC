using AmbevConexao.Model.Dtos;
using AmbevConexao.Model.Entities;
using AmbevConexao.Model.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace AmbevConexao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _service;

        //TODO:usar tasks
        //TODO:usar IActionResult
        //TODO: ancapsular parametros de post e patch em objetos
        public AlunoController(IAlunoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<AlunoEntity> Get()
        {
            var result = _service.BuscarAlunos();
            return result;
        }

        [HttpGet("{id}")]
        public AlunoEntity Get(int id)
        {
            var result = _service.BuscarAluno(id);

            return result;
        }

        [HttpPost]
        public IEnumerable<AlunoEntity> Post([FromBody] AdicionarAlunoDto dto)
        {
            var result = _service.AdicionarAluno(dto.Nome, dto.Endereco, dto.Email);

            return result;
        }

        [HttpPatch("{id}")]
        public AlunoEntity Put(int id, [FromBody] AlterarAlunoDto dto)
        {
            dto.Id = id;
            var result = _service.AlterarAluno(id, dto.Nome, dto.Endereco, dto.Email);

            return result;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var result = _service.InativarAluno(id);
        }
    }
}
