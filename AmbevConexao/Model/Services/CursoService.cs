using AmbevConexao.Model.Entities;
using AmbevConexao.Model.Interfaces.Repository;
using AmbevConexao.Model.Interfaces.Services;

namespace AmbevConexao.Model.Services;

public class CursoService : ICursoService
{
    private readonly ICursoRepository _repository;

    public CursoService(ICursoRepository repository) => _repository = repository;

    public List<CursoEntity> AdicionarCurso(string titulo, string descricao)
    {
        var curso = CursoEntity.NovoCurso(titulo, descricao);

        _repository.Incluir(curso);

        var result = _repository.SelecionarTudo();

        return result;
    }

    public CursoEntity BuscarCurso(int id)
    {
        var curso = _repository.Selecionar(id);

        return curso;
    }

    public List<CursoEntity> BuscarCursos()
    {
        var cursos = _repository.SelecionarTudo();

        return cursos.ToList();
    }

    public CursoEntity InativarCurso(int id)
    {
        var curso = _repository.Selecionar(id);
        if (curso is null)
        {
            return null;
        }

        curso.DesativarCurso();

        _repository.Alterar(curso);

        return curso;
    }

    public CursoEntity IniciarCurso(int id, DateTime dataInicio, int idProfessor)
    {
        var curso = _repository.Selecionar(id);
        if (curso is null)
        {
            return null;
        }

        curso.AtivarCurso(dataInicio, idProfessor);

        _repository.Alterar(curso);

        return curso;
    }
}
