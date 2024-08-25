using AmbevConexao.Model.Entities;

namespace AmbevConexao.Model.Interfaces.Services;

public interface IMatriculaService
{
    public List<MatriculaEntity> BuscarMatriculas();
    public MatriculaEntity BuscarMatricula(int id);
    public string MatricularAluno(int idAluno, int idCurso);
}
