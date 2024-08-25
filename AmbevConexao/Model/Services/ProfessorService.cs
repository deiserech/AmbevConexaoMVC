using AmbevConexao.Model.Entities;
using AmbevConexao.Model.Interfaces.Repository;
using AmbevConexao.Model.Interfaces.Services;

namespace AmbevConexao.Model.Services;

public class ProfessorService : IProfessorService
{
    private readonly IProfessorRepository _repository;

    public ProfessorService(IProfessorRepository repository) => _repository = repository;

    public List<ProfessorEntity> AdicionarProfessor(string nome, string email)
    {
        var professor = ProfessorEntity.NovoProfessor(nome, email);

        _repository.Incluir(professor);

        var result = _repository.SelecionarTudo();
        return result;
    }

    public ProfessorEntity? AlterarProfessor(int id, string nome, string email)
    {
        var professor = _repository.Selecionar(id);
        if (professor is null)
        {
            return null;
        }

        professor.AlterarNome(nome);
        professor.AlterarEmail(email);

        _repository.Alterar(professor);

        return professor;
    }

    public ProfessorEntity BuscarProfessor(int id)
    {
        var professor = _repository.Selecionar(id);

        return professor;
    }

    public List<ProfessorEntity> BuscarProfessores()
    {
        var professores = _repository.SelecionarTudo();

        return professores.ToList();
    }
}
