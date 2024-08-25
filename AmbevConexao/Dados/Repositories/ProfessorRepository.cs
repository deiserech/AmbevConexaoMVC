using AmbevConexao.Infraestructure.Common;
using AmbevConexao.Model.Entities;
using AmbevConexao.Model.Interfaces.Repository;

namespace AmbevConexao.Infraestructure.Professor
{
    public class ProfessorRepository : BaseRepository<ProfessorEntity>, IProfessorRepository
    {
        public ProfessorRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
