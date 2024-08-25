using AmbevConexao.Model.Entities;
using AmbevConexao.Model.Interfaces.Repository;
using AmbevConexao.Model.Interfaces.Services;

namespace AmbevConexao.Model.Services;

public class AlunoService : IAlunoService
{
    private readonly IAlunoRepository _repository;

    public AlunoService(IAlunoRepository repository)
    {
        _repository = repository;
    }

    public List<AlunoEntity> AdicionarAluno(string nome, string endereco, string email)
    {
        var aluno = AlunoEntity.NovoAluno(nome, endereco, email);

        _repository.Incluir(aluno);

        var result = _repository.SelecionarTudo();

        return result;
    }

    public AlunoEntity AlterarAluno(int id, string nome, string endereco, string email)
    {
        var aluno = _repository.Selecionar(id);
        if (aluno is null)
            return null;


        aluno.AlterarNome(nome);
        aluno.AlterarEndereco(endereco);
        aluno.AlterarEmail(email);

        _repository.Alterar(aluno);

        return aluno;
    }

    public AlunoEntity BuscarAluno(int id)
    {
        var aluno = _repository.Selecionar(id);

        return aluno;
    }

    public List<AlunoEntity> BuscarAlunos()
    {
        var alunos = _repository.SelecionarTudo();

        return alunos.ToList();
    }
    public AlunoEntity InativarAluno(int id)
    {
        var aluno = _repository.Selecionar(id);
        if (aluno is null)
        {
            return null;
        }

        aluno.Inativar();
        _repository.Alterar(aluno);

        return aluno;
    }
}
