using AmbevConexao.Model.Common.Enums;
using AmbevConexao.Model.Entities;
using AmbevConexao.Model.Interfaces.Repository;
using AmbevConexao.Model.Interfaces.Services;

namespace AmbevConexao.Model.Services;

public class MatriculaService : IMatriculaService
{
    private readonly IMatriculaRepository _matriculaRepository;
    private readonly IAlunoRepository _alunoRepository;
    private readonly ICursoRepository _cursoRepository;

    public MatriculaService(IMatriculaRepository matriculaRepository,
                            IAlunoRepository alunoRepository,
                            ICursoRepository cursoRepository)
    {
        _matriculaRepository = matriculaRepository;
        _alunoRepository = alunoRepository;
        _cursoRepository = cursoRepository;
    }

    public List<MatriculaEntity> BuscarMatriculas()
    {
        var matriculas = _matriculaRepository.SelecionarTudo();

        return matriculas.ToList();
    }

    public MatriculaEntity BuscarMatricula(int id)
    {
        var matricula = _matriculaRepository.Selecionar(id);

        return matricula;
    }

    public string MatricularAluno(int idAluno, int idCurso)
    {
        var aluno = _alunoRepository.Selecionar(idAluno);
        var curso = _cursoRepository.Selecionar(idCurso);

        if (curso is null || aluno is null)
        {
            return "Aluno ou Curso não existem";
        }

        var matricula = MatriculaEntity.MatricularAluno(curso, aluno);
        if (matricula.Status == StatusMatricula.Ativo)
        {
            _matriculaRepository.Incluir(matricula);
        }
        return matricula.DescricaoStatus;
    }
}
