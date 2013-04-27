namespace Infrasturcture.Core
{
    using System.Linq;

    public interface IDatabaseContext
    {
        IQueryable<TEntity> Query<TEntity>();
        void Save(object entity);
    }
}