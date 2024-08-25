using AmbevConexao.Model.Dtos;
using AmbevConexao.Model.Entities;
using AmbevConexao.Model.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace AmbevConexao.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly ICursoService _service;

        public CursoController(ICursoService cursoService)
        {
            _service = cursoService;
        }

        [HttpGet]
        public IEnumerable<CursoEntity> Get()
        {
            var result = _service.BuscarCursos();
            return result;
        }

        [HttpGet("{id}")]
        public CursoEntity Get(int id)
        {
            var result = _service.BuscarCurso(id);
            return result;
        }

        [HttpPost]
        public IEnumerable<CursoEntity> Post([FromBody] AdicionarCursoDto dto)
        {
            var result = _service.AdicionarCurso(dto.Titulo, dto.Descricao);
            return result;
        }

        [HttpPatch("/iniciar/{id}")]
        public CursoEntity Patch(int id, [FromBody] IniciarCursoDto dto)
        {
            dto.Id = id;
            var result = _service.IniciarCurso(id, dto.DataInicio, dto.IdProfessor);
            return result;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var result = _service.InativarCurso(id);
        }
    }
}
