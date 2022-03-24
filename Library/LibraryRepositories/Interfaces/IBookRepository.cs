using LibraryEntities.Models;
using System.Linq.Expressions;

namespace LibraryDb
{
    public interface IBookRepository
    {
        List<Borrowing> FindBorrows(Expression<Func<Borrowing, bool>> predicate);
        Borrowing FindBorrow(Expression<Func<Borrowing, bool>> predicate);
        void RemoveBorrow(Borrowing entity);
        List<Book> ClientFilterBook(int selectedFillter, string value);
        List<Book> GetBooksCmbDB();
    }
}
