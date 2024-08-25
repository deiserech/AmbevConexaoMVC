using AmbevConexao.Model.Entities;

namespace AmbevConexao.Model.Interfaces.Services;

public interface IProfessorService
{
    public List<ProfessorEntity> AdicionarProfessor(string nome, string email);
    public ProfessorEntity AlterarProfessor(int id, string nome, string email);
    public List<ProfessorEntity> BuscarProfessores();
    public ProfessorEntity BuscarProfessor(int id);

}
