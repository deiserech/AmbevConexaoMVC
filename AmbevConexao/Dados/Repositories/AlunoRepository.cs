using AmbevConexao.Infraestructure.Common;
using AmbevConexao.Model.Entities;
using AmbevConexao.Model.Interfaces.Repository;

namespace AmbevConexao.Infraestructure.Aluno
{
    public class AlunoRepository : BaseRepository<AlunoEntity>, IAlunoRepository
    {
        public AlunoRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
