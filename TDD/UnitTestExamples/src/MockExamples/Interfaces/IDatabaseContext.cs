namespace MockExamples.Interfaces
{
    using System.Linq;

    public interface IDatabaseContext
    {
        IQueryable<T> Query<T>();
    }
}