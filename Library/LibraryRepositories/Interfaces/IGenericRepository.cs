using System.Linq.Expressions;

namespace LibraryDb
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        T GetById(int id);
        List<T> GetAll();
        List<T> Find(Expression<Func<T, bool>> predicate);
        List<T> Filter(int selectedFilter, string value);
        bool Remove(int id);
        void Save();
        void Update(T entity);

    }
}
