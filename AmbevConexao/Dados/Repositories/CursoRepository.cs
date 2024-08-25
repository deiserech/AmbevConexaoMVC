using AmbevConexao.Infraestructure.Common;
using AmbevConexao.Model.Entities;
using AmbevConexao.Model.Interfaces.Repository;

namespace AmbevConexao.Infraestructure.Curso;

public sealed class CursoRepository(Contexto contexto) : BaseRepository<CursoEntity>(contexto), ICursoRepository
{
}
