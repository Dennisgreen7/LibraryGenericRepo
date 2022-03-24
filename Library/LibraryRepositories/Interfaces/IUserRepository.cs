using LibraryEntities.Models;
using System.Linq.Expressions;

namespace LibraryDb
{
    public interface IUserRepository:IGenericRepository<User>
    {
        List<Borrowing> FindBorrows(Expression<Func<Borrowing, bool>> predicate);
        Borrowing FindBorrow(Expression<Func<Borrowing, bool>> predicate);
        void RemoveBorrow(Borrowing entity);
    }
}
