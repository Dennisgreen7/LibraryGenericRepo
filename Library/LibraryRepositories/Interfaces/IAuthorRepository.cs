using System.Linq.Expressions;
using LibraryEntities.Models;

namespace LibraryDb
{
    public interface IAuthorRepository:IGenericRepository<Author>
    {
        List<Borrowing> FindBorrows(Expression<Func<Borrowing, bool>> predicate);
        Borrowing FindBorrow(Expression<Func<Borrowing, bool>> predicate);
        List<Book> FindBooks(Expression<Func<Book, bool>> predicate);
        void RemoveBorrow(Borrowing entity);
        void RemoveBook(Book entity);
    }
}
