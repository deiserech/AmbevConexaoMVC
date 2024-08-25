using AmbevConexao.Infraestructure.Common;
using AmbevConexao.Model.Entities;
using AmbevConexao.Model.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace AmbevConexao.Infraestructure.Matricula
{
    public class MatriculaRepository(Contexto contexto) : BaseRepository<MatriculaEntity>(contexto), IMatriculaRepository
    {
        public List<MatriculaEntity> SelecionarTudoCompleto()
        {
            var t = _contexto.Matricula
                .Include(x => x.Aluno)
                .Include(x => x.Curso);

            return t.ToList();
        }
    }
}
