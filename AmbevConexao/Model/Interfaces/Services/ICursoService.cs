
using AmbevConexao.Model.Entities;

namespace AmbevConexao.Model.Interfaces.Services;

public interface ICursoService
{
    public List<CursoEntity> AdicionarCurso(string titulo, string descricao);
    public CursoEntity IniciarCurso(int id, DateTime dataInicio, int idProfessor);
    public List<CursoEntity> BuscarCursos();
    public CursoEntity BuscarCurso(int id);
    public CursoEntity InativarCurso(int id);

}
