using LibraryEntities.Models;
using System.Linq.Expressions;

namespace LibraryDb
{
    public interface IBorrowRepository:IGenericRepository<Borrowing>
    {
        List<Borrowing> ClientFilterBorrow(int selectedfillter, string value, User entity);
        List<Borrowing> GetDBClientBorrowings(User entity);
        Book FindBook(Expression<Func<Book, bool>> predicate);
        bool ReturnBook(string id);
        void bookChek(Borrowing entity, bool IsSame, string newBookId);
    }
}
