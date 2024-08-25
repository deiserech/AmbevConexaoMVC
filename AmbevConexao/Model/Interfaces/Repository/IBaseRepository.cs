using AmbevConexao.Model.Interfaces.Common;

namespace AmbevConexao.Model.Interfaces.Repository;

public interface IBaseRepository<T> where T : class, IEntity
{
    public void Incluir(T entity);

    public void Alterar(T entity);

    public T Selecionar(int id);

    public List<T> SelecionarTudo();

    public void Excluir(int id);

    public void Dispose();
}
