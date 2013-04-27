namespace Infrastructure.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Infrasturcture.Core;

    public class EntityFrameworkDataContext : IDatabaseContext
    {
        public IQueryable<TEntity> Query<TEntity>()
        {
            return new List<TEntity>().AsQueryable();
        }

        public void Save(object entity)
        {
            Console.WriteLine("Save entity: {0}", entity);
        }
    }
}