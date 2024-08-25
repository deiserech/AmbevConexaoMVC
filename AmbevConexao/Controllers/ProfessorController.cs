using AmbevConexao.Model.Dtos;
using AmbevConexao.Model.Entities;
using AmbevConexao.Model.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace AmbevConexao.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProfessorController : ControllerBase
{
    private readonly IProfessorService _service;

    public ProfessorController(IProfessorService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<ProfessorEntity> Get()
    {
        var result = _service.BuscarProfessores();
        return result;
    }

    [HttpGet("{id}")]
    public ProfessorEntity Get(int id)
    {
        var result = _service.BuscarProfessor(id);
        return result;
    }

    [HttpPost]
    public IEnumerable<ProfessorEntity> Post([FromBody] AdicionarProfessorDto dto)
    {
        var result = _service.AdicionarProfessor(dto.Nome, dto.Email);
        return result;
    }

    [HttpPatch("{id}")]
    public ProfessorEntity Patch(int id, [FromBody] AlterarProfessorDto dto)
    {
        dto.Id = id;
        var result = _service.AlterarProfessor(id, dto.Nome, dto.Email);
        return result;
    }
}

