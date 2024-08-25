namespace AmbevConexao.Model.Interfaces.Services;
using AmbevConexao.Model.Entities;

public interface IAlunoService
{
    public  List<AlunoEntity> AdicionarAluno(string nome, string endereco, string email);
    public AlunoEntity AlterarAluno(int id, string nome, string endereco, string email);
    public List<AlunoEntity> BuscarAlunos();
    public AlunoEntity BuscarAluno(int id);
    public AlunoEntity InativarAluno(int id);
}
