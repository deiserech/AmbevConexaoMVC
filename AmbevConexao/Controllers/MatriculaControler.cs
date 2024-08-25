using AmbevConexao.Model.Dtos;
using AmbevConexao.Model.Entities;
using AmbevConexao.Model.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace AmbevConexao.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MatriculaController : ControllerBase
    {
        private readonly IMatriculaService _service;

        public MatriculaController(IMatriculaService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<MatriculaEntity> Get()
        {
            var result = _service.BuscarMatriculas();
            return result;
        }

        [HttpGet("{id}")]
        public MatriculaEntity Get(int id)
        {
            var result = _service.BuscarMatricula(id);
            return result;
        }

        [HttpPost]
        public string Post([FromBody] MatricularAlunoDto dto)
        {
            var result = _service.MatricularAluno(dto.IdAluno, dto.IdCurso);
            return result;
        }
    }
}

